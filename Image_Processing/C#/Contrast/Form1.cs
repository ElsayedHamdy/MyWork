using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Brightness
{
    public partial class Form1 : Form
    {
        /* Defining Variables:
         * Image >> to Store the Required Image.
         * ImageData >> to store The Image Data In the Memory
         * buffer >> buffering array used to edit the Image Data and to return back the edited ones
         * r,g,b >> to hold the rgb values
         * contrast >> to hold the contrast value
         * factor >> to hold calculated contrast factor
         * pointer >> to hold the address to the blue value of the first pixel in the memory
         */
        private Bitmap Image;
        private BitmapData ImageData;
        private byte[] buffer;
        private int r,g,b,contrast;
        private float factor;
        private IntPtr pointer;
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
            }
            pictureBox1.Image = (Bitmap)Image.Clone();
        }
        /* Converting The Image file:
         * 1-Lock the Image Bits in the memory (PixelFormat.Format24bppRgb means that the program is going to lock only red , green and blue without including the alpha channel)
         * 2-initializing the buffer array it's going to have all the image data (the image have height and width which leads to total pixel count = height * width and each pixel have r,g,b so the array length = height*width*3)
         * 3-set the pointer to the location of the blue value of the first pixel of the image
         * 4-copy the Image Data to the Buffer Array
         * 5-Loop through each pixel and make the loop step = 3 (i+=3)
         * 6-Calculate factor foreach pixel
         * 7-calculate the new value for each channel
         * 8-copy back the image Data from buffer to Image using the same pointer location
         * 9-unlock the image bits
         */
        private void convertbtn_Click(object sender, EventArgs e)
        {
            /* Important Note:
             * we are using buffer_image in order to not making any changes to the orignal image
             * so we are making new image out of applying contrast vlue to the orignal one
             * then returning the new image to picturebox
             */
            using (Bitmap buffer_image = (Bitmap)Image.Clone())  
            {
                contrast = (int)updown.Value;
                ImageData = buffer_image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                buffer = new byte[3 * Image.Width * Image.Height];
                pointer = ImageData.Scan0;
                Marshal.Copy(pointer, buffer, 0, buffer.Length);
                for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
                {
                    factor = (259 * ((float)contrast + 255)) / (255 * (259 - (float)contrast));
                    b = (int)(factor * (buffer[i] - 128) + 128);
                    g = (int)(factor * (buffer[i + 1] - 128) + 128);
                    r = (int)(factor * (buffer[i + 2] - 128) + 128);
                    if (b > 255) b = 255;
                    else if (b < 0) b = 0;
                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;
                    if (r > 255) r = 255;
                    else if (r < 0) r = 0;
                    buffer[i] = (byte)b;
                    buffer[i + 1] = (byte)g;
                    buffer[i + 2] = (byte)r;
                }
                Marshal.Copy(buffer, 0, pointer, buffer.Length);
                buffer_image.UnlockBits(ImageData);
                pictureBox1.Image = (Bitmap)buffer_image.Clone();
            }
        }
    }
}
