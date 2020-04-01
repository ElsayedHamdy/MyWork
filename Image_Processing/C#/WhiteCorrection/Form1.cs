using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WhiteCorrection
{
    public partial class Form1 : Form
    {
        /* Defining Variables:
         * Image >> to Store the Required Image.
         * ImageData >> to store The Image Data In the Memory
         * buffer >> buffering array used to edit the Image Data and to return back the edited ones
         * r,g,b >> to hold the rgb values
         * grayscale >> to hold the grayscale value 
         * K_r,K_g,K_b >> the weights (to be multiplied with the pixel rgb channels)
         * sumr,sumb,sumg >> the Image Average values for each channel 
         * pointer >> to hold the address to the blue value of the first pixel in the memory
         */
        private Bitmap Image;
        private BitmapData ImageData;
        private byte[] buffer;
        double k_r, k_g, k_b;
        double sumr, sumb, sumg, grayscale;
        int[] r, g, b;
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
                pictureBox1.Image.Save(sfd.FileName,ImageFormat.Jpeg);
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
         * 6-assigin each channel value to it's corresponding array
         * 7-calculate the Average value for each channel
         * 8-calculate grayscale value of all the channels
         * 9-calculate the weight for each channel
         * 10-Loop through each pixel and multiply it's channels with it's corresponding weight
         * 9-copy back the image Data from buffer to Image using the same pointer location
         * 10-unlock the image bits
         */
        private void convertbtn_Click(object sender, EventArgs e)
        {
            ImageData = Image.LockBits(new Rectangle (0,0,Image.Width,Image.Height),ImageLockMode.ReadWrite,PixelFormat.Format24bppRgb);
            buffer = new byte[3 * Image.Width * Image.Height];
            r = new int[Image.Width * Image.Height];
            g = new int[Image.Width * Image.Height];
            b = new int[Image.Width * Image.Height];
            pointer = ImageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int i = 0,i2 = 0; i < Image.Height * 3 * Image.Width; i += 3,i2++)
            {
                b[i2] = buffer[i];
                g[i2] = buffer[i + 1];
                r[i2] = buffer[i + 2];
            }
            sumb = b.Average();
            sumg = g.Average();
            sumr = r.Average();
            grayscale = (sumr + sumg + sumb) / 3.0;
            k_b = grayscale / sumb;
            k_g = grayscale / sumg;
            k_r = grayscale / sumr;
            for (int i = 0, i2 = 0; i < Image.Height * 3 * Image.Width; i += 3, i2++)
            {
                buffer[i] =     (k_b * b[i2] > 255) ? (byte)255 : (byte)(k_b * b[i2]);
                buffer[i + 1] = (k_g * g[i2] > 255) ? (byte)255 : (byte)(k_g * g[i2]);
                buffer[i + 2] = (k_r * r[i2] > 255) ? (byte)255 : (byte)(k_r * r[i2]);
            }
            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(ImageData);
            pictureBox1.Image = Image;
        }
    }
}
