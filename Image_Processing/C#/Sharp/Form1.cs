using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sharp
{
    public partial class Form1 : Form
    {
        /* Defining Variables:
         * Image  >> to Store the Required Image.
         * Image2 >> output Image.
         * ImageData  >> to store The Image Data In the Memory (input image)
         * ImageData2 >> to store The Image Data In the Memory (output image)
         * buffer  >> buffering array used to edite the Image Data and to return back the edited ones to output array
         * buffer2 >> output array
         * r,g,b >> to hold the rgb values
         * pointer  >> to hold the address to the red value of the first pixel in the memory (input array)
         * pointer2 >> to hold the address to the red value of the first pixel in the memory (output array)
         * location >> to hold the location of current pixel
         * weight >> to hold the weight corresponding to pixel in the window
         * weights >> to hold the weights kernel
         */
        private Bitmap Image,Image2;
        private BitmapData ImageData,ImageData2;
        private byte[] buffer,buffer2;
        private int r,g,b,location;
        private sbyte weight;
        private sbyte[,] weights;
        private IntPtr pointer,pointer2;
        public Form1()
        {
            InitializeComponent();
            weights = new sbyte[,] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
        }
        /* Saving the Image file:
         * type the file name followed by the file extension (for example new.jpg)
         */
        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName,ImageFormat.Bmp);
            }
        }
        /* Loading the Image file
         * Showing it in the picturebox
         */
        private void loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image = new Bitmap(ofd.FileName);
                Image2 = new Bitmap(Image.Width, Image.Height);
            }
            pictureBox1.Image = Image;
        }
        /* Converting The Image file:
         * 1-Lock the Image Bits in the memory (PixelFormat.Format24bppRgb means that the program is going to lock only red , green and blue without including the alpha channel)
         * 2-initializing the buffer array it's going to have all the image data (the image have height and width which leads to total pixel count = height * width and each pixel have r,g,b so the array length = height*width*3)
         * 3-set the pointer to the location of the red value of the first pixel of the image
         * 4-copy the Image Data to the Buffer Array
         * 5-Loop through each pixel and make the loop step = 3 (i+=3)
         * 6-apply the window on the current pixel
         * 7-multiply each pixel in the window to each corresponding weight then add the value to it's corresponding channel 
         * 8-assign the channels total values to output array once the you finished looping through the window
         * 9-unlock the image bits
         */
        private void convertbtn_Click(object sender, EventArgs e)
        {
            ImageData  = Image.LockBits(new Rectangle (0,0,Image.Width,Image.Height),ImageLockMode.ReadOnly,PixelFormat.Format24bppRgb);
            ImageData2 = Image2.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer  = new byte[ImageData.Stride * Image.Height];
            buffer2 = new byte[ImageData.Stride * Image.Height];
            pointer  = ImageData.Scan0;
            pointer2 = ImageData2.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int y = 0; y < Image.Height ; y++)
            {
                for (int x = 0; x < Image.Width * 3; x+=3)
                {
                    r = g = b = 0; //reset the channels values
                    for (int yy = -(int)Math.Floor(weights.GetLength(0) / 2.0d), yyy = 0; yy <= (int)Math.Floor(weights.GetLength(0) / 2.0d); yy++,yyy++)
                    {
                        if (y + yy >= 0 && y + yy < Image.Height) //to prevent crossing the bounds of the array
                        {
                            for (int xx = -(int)Math.Floor(weights.GetLength(1) / 2.0d) * 3, xxx = 0; xx <= (int)Math.Floor(weights.GetLength(1) / 2.0d) * 3; xx += 3, xxx++)
                            {
                                if (x + xx >= 0 && x + xx <= Image.Width * 3 - 3) //to prevent crossing the bounds of the array
                                {
                                    location = x + xx + (yy + y) * ImageData.Stride; //to get the location of any pixel >> location = x + y * Stride
                                    weight = weights[yyy, xxx];
                                    //applying the same weight to all channels
                                    b += buffer[location] * weight;
                                    g += buffer[location + 1] * weight;
                                    r += buffer[location + 2] * weight;
                                }
                            }
                        }
                    }
                    if (b > 255) b = 255;
                    else if (b < 0) b = 0;
                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;
                    if (r > 255) r = 255;
                    else if (r < 0) r = 0;
                    buffer2[location] = (byte)b;
                    buffer2[location + 1] = (byte)g;
                    buffer2[location + 2] = (byte)r;
                }
            }
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            Image.UnlockBits(ImageData);
            Image2.UnlockBits(ImageData2);
            // to remove the black border around the output image
            pictureBox1.Image = new Bitmap(Image2.Clone(new Rectangle((int)Math.Floor(weights.GetLength(1) / 2.0d), (int)Math.Floor(weights.GetLength(0) / 2.0d), Image2.Width - (int)Math.Floor(weights.GetLength(1) / 2.0d), Image2.Height - (int)Math.Floor(weights.GetLength(0) / 2.0d)),PixelFormat.Format24bppRgb),Image2.Size);
        }
    }
}