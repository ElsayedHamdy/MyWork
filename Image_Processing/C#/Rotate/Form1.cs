using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rotate
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
         * pointer  >> to hold the address to the red value of the first pixel in the memory (input array)
         * pointer2 >> to hold the address to the red value of the first pixel in the memory (output array)
         * location >> to hold the location of current pixel in input image
         * location2 >> to hold the location of current pixel in output image
         */
        private Bitmap Image,Image2;
        private BitmapData ImageData,ImageData2;
        private byte[] buffer,buffer2;
        private int location,location2;
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
                Image2 = new Bitmap(Image.Height, Image.Width);
            }
            pictureBox1.Image = Image;
        }
        /* Rotating The Image file:
         * 1-Lock the Image Bits in the memory (PixelFormat.Format24bppRgb means that the program is going to lock only red , green and blue without including the alpha channel)
         * 2-initializing the buffer array it's going to have all the image data (the image have height and width which leads to total pixel count = height * width and each pixel have r,g,b so the array length = height*width*3)
         * 3-set the pointer to the location of the red value of the first pixel of the image
         * 4-copy the Image Data to the Buffer Array
         * 5-Loop through each pixel in the input image and make the loop step = 3 (i+=3)
         * 6-Loop through each pixel in the output image and make the loop step = 3 (i+=3)
         * 7-copy the current pixel in the input image to the current location in the output image
         * 8-unlock the image bits
         */
        private void cw_Click(object sender, EventArgs e)
        {
            ImageData  = Image.LockBits(new Rectangle (0,0,Image.Width,Image.Height),ImageLockMode.ReadOnly,PixelFormat.Format24bppRgb);
            ImageData2 = Image2.LockBits(new Rectangle(0, 0, Image2.Width, Image2.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer  = new byte[ImageData.Stride * Image.Height];
            buffer2 = new byte[ImageData2.Stride * Image2.Height];
            pointer  = ImageData.Scan0;
            pointer2 = ImageData2.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int y = 0 , xx = Image2.Width * 3 - 3; y < Image.Height ; y++ , xx -= 3)
            {
                for (int x = 0 , yy = 0; x < Image.Width * 3; x += 3,yy++)
                {
                    location = x + y * ImageData.Stride;
                    location2 = xx + yy * ImageData2.Stride;
                    buffer2[location2] = buffer[location];
                    buffer2[location2 + 1] = buffer[location + 1];
                    buffer2[location2 + 2] = buffer[location + 2];
                }
            }
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            Image.UnlockBits(ImageData);
            Image2.UnlockBits(ImageData2);
            pictureBox1.Image = Image2;
        }
        private void ccw_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            ImageData2 = Image2.LockBits(new Rectangle(0, 0, Image2.Width, Image2.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer = new byte[ImageData.Stride * Image.Height];
            buffer2 = new byte[ImageData2.Stride * Image2.Height];
            pointer = ImageData.Scan0;
            pointer2 = ImageData2.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int y = 0, xx = 0; y < Image.Height; y++, xx += 3)
            {
                for (int x = 0, yy = Image2.Height - 1; x < Image.Width * 3; x += 3, yy--)
                {
                    location = x + y * ImageData.Stride;
                    location2 = xx + yy * ImageData2.Stride;
                    buffer2[location2] = buffer[location];
                    buffer2[location2 + 1] = buffer[location + 1];
                    buffer2[location2 + 2] = buffer[location + 2];
                }
            }
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            Image.UnlockBits(ImageData);
            Image2.UnlockBits(ImageData2);
            pictureBox1.Image = Image2;
        }
    }
}