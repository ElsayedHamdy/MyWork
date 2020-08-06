using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Demo_Loading_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //pictureBox1.Image = new Bitmap("./test.jpg");
            
            //pictureBox1.Image.Save("./test.jpg");

            //best way to load images and avoid most of GDI errors
            using (Bitmap bmb = new Bitmap("./test.jpg"))
            {
                MemoryStream m = new MemoryStream();
                bmb.Save(m, ImageFormat.Bmp);
                pictureBox1.Image = Image.FromStream(m);
            }
            //best way to save images and avoid most of GDI errors
            using (Bitmap bmb = (Bitmap)pictureBox1.Image.Clone())
            {
                bmb.Save("./test.jpg", bmb.RawFormat);
            }
        }
    }
}
