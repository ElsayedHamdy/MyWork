using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sepia
{
    public partial class Form1 : Form
    {
        /* Defining Variables:
         * Image >> to Store the Required Image.
         * ImageData >> to store The Image Data In the Memory
         * buffer >> buffering array used to edit the Image Data and to return back the edited ones
         * r,g,b >> to hold the rgb values
         * pointer >> to hold the address to the blue value of the first pixel in the memory
         */
        private Bitmap Image;
        private BitmapData ImageData;
        private byte[] buffer;
        private int r,g,b;
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
            pictureBox1.Image = Image;
        }
        /* Converting The Image file:
         * 1-Lock the Image Bits in the memory (PixelFormat.Format24bppRgb means that the program is going to lock only red , green and blue without including the alpha channel)
         * 2-initializing the buffer array it's going to have all the image data (the image have height and width which leads to total pixel count = height * width and each pixel have r,g,b so the array length = height*width*3)
         * 3-set the pointer to the location of the blue value of the first pixel of the image
         * 4-copy the Image Data to the Buffer Array
         * 5-Loop through each pixel and make the loop step = 3 (i+=3)
         * 6-calculate the new value for each channel
         * 7-copy back the image Data from buffer to Image using the same pointer location
         * 8-unlock the image bits
         */
        private void convertbtn_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle (0,0,Image.Width,Image.Height),ImageLockMode.ReadWrite,PixelFormat.Format24bppRgb);
            buffer = new byte[3 * Image.Width * Image.Height];
            pointer = ImageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int i = 0; i < Image.Height * 3 * Image.Width; i+=3)
            {
                b = (int)((buffer[i]) * .131 + (buffer[i + 1]) * .534 + (buffer[i + 2]) * .272);
                g = (int)((buffer[i]) * .168 + (buffer[i + 1]) * .686 + (buffer[i + 2]) * .349);
                r = (int)((buffer[i]) * .189 + (buffer[i + 1]) * .769 + (buffer[i + 2]) * .393);
                b = (b > 255) ? 255 : b;
                g = (g > 255) ? 255 : g;
                r = (r > 255) ? 255 : r;
                buffer[i]     = (byte)b;
                buffer[i + 1] = (byte)g;
                buffer[i + 2] = (byte)r;
            }
            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(ImageData);
            pictureBox1.Image = Image;
        }
    }
}
