using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if(opd.ShowDialog()==DialogResult.OK)
            {
                try {
                    Bitmap img = new Bitmap(opd.FileName);
                    if (img.PixelFormat==PixelFormat.Format24bppRgb)
                    {
                        pictureBox1.Image = edite(new Bitmap(opd.FileName));
                    }
                    }
                catch
                {
                    if(MessageBox.Show("this is not an image file","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error)==DialogResult.OK)
                    {

                    }else
                    {
                        Application.Exit();
                    }
                }
                finally { }
                
            }
            Bitmap edite (Bitmap img)
            {
                Color color = new Color();
                for(int x=0;x<img.Width;x++)
                {
                    for(int y=0;y<img.Height;y++)
                    {
                        color = img.GetPixel(x,y);
                        img.SetPixel(x, y,Color.FromArgb((color.R+color.G+color.B)/3, (color.R + color.G + color.B) / 3, (color.R + color.G + color.B) / 3));
                    }
                }
                return img;
            }
        }
    }
    
}
