using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Smooth
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
         * location2 >> to hold the location of current pixel in the window
         * count >> to hold the count of all pixels in the window
         * glid >> to hold half the window size
         */
        private Bitmap Image,Image2;
        private BitmapData ImageData,ImageData2;
        private byte[] buffer,buffer2;
        private int r,g,b,location,location2,count,glid;
        private IntPtr pointer,pointer2;
        public Form1()
        {
            InitializeComponent();
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
         * 7-sum all pixels in the window and divide them by their count
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
            glid = (int)numsmooth.Value;
            for (int y = 0; y < Image.Height ; y++) //Same idea you need to watch sharp by c# video first
            {
                for (int x = 0; x < Image.Width * 3; x+=3)
                {
                    r = g = b = count = 0; //reset the channels values
                    location = x + y * ImageData.Stride; //to get the location of any pixel >> location = x + y * Stride
                    for (int yy = -glid, yyy = 0; yy <= glid; yy++,yyy++)
                    {
                        if (y + yy >= 0 && y + yy < Image.Height) //to prevent crossing the bounds of the array
                        {
                            for (int xx = -glid * 3, xxx = 0; xx <= glid * 3; xx += 3, xxx++)
                            {
                                if (x + xx >= 0 && x + xx <= Image.Width * 3 - 3) //to prevent crossing the bounds of the array
                                {
                                    location2 = x + xx + (yy + y) * ImageData.Stride; //to get the location of any pixel >> location = x + y * Stride
                                    b += buffer[location2];
                                    g += buffer[location2 + 1];
                                    r += buffer[location2 + 2];
                                    count++;
                                }
                            }
                        }
                    }
                    b = b / count;
                    g = g / count;
                    r = r / count;
                    if (b > 255) b = 255;
                    if (g > 255) g = 255;
                    if (r > 255) r = 255;
                    buffer2[location] = (byte)b;
                    buffer2[location + 1] = (byte)g;
                    buffer2[location + 2] = (byte)r;
                }
            }
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            Image.UnlockBits(ImageData);
            Image2.UnlockBits(ImageData2);
            pictureBox1.Image = Image2;
        }
    }
}