using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Difference
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
         * brightness1 >> to hold the brightness value of current pixel
         * brightness2 >> to hold the brightness value of previous pixel
         * sub >> to hold the difference between brightness1 and brightness2
         */
        private Bitmap Image,Image2;
        private BitmapData ImageData,ImageData2;
        private byte[] buffer,buffer2;
        private byte r,g,b, brightness1, brightness2, sub;
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
                pictureBox1.Image.Save(sfd.FileName);
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
         * 6-assigin each channel value to it's corresponding variable
         * 7-check for current pixel's channel values to find the biggest value that would be the brightness of the pixel (brightness1)
         * 8-check for previous pixel's channel values to find the biggest value that would be the brightness of the pixel (brightness2)
         * 9-subtract brightness1 and brightness2 and assigin the value to output array
         * 8-copy back the image Data2 from buffer to Image2 using the same pointer location
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
            for(int i=0; i<Image.Width*Image.Height*3; i+=3)
            { 
                    if (i != 0)
                    {
                        r = buffer[i];
                        g = buffer[i + 1];
                        b = buffer[i + 2];
                        if (b != g | b != r | g != r) brightness1 = Math.Max(Math.Max(r, g), b);
                        else brightness1 = b;
                        r = buffer[i - 3];
                        g = buffer[i - 2];
                        b = buffer[i - 1];
                        if (b != g | b != r | g != r) brightness2 = Math.Max(Math.Max(r, g), b);
                        else brightness2 = b;
                        sub = (byte)Math.Abs(brightness1 - brightness2);
                        buffer2[i] = sub;
                        buffer2[i + 1] = sub;
                        buffer2[i + 2] = sub;
                    }
                    else
                    {
                        buffer2[i]     = buffer[i];
                        buffer2[i + 1] = buffer[i + 1];
                        buffer2[i + 2] = buffer[i + 2];
                    }
            }
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            Image.UnlockBits(ImageData);
            Image2.UnlockBits(ImageData2);
            pictureBox1.Image = Image2;
        }
    }
}