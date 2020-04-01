using System;
using System.Drawing;
using System.Windows.Forms;
namespace ImageViewer
{
    public partial class Form1 : Form
    {
        Bitmap orignal, work;
        Point mouselocation; //gets the mouse location when the left mouse key pressed on the picturebox while scrollbars are visible
        float aspect;
        Point upperleftcorner //gets the upperleftcorner of the picturebox 
        {
            get
            {
                int x, y;
                x = (panel6.ClientSize.Width - (work.Width * trackBar1.Value / 10)) / 2;
                y = (panel6.ClientSize.Height - (work.Height * trackBar1.Value / 10)) / 2;
                if (x < 0) x = 0;
                if (y < 0) y = 0;
                return new Point(x, y);
            }
        }
        public Form1()
        {
            InitializeComponent();
            orignal = new Bitmap(@".\test.jpg"); //width=height
            //orignal = new Bitmap(@".\taylor-hernandez-DLKR_x3T_7s-unsplash.jpg"); //height>width
            //orignal = new Bitmap(@".\Screenshot (2).png"); //height<width
            aspect = (float)orignal.Width / orignal.Height; //the aspect ratio
            if (Screen.PrimaryScreen.Bounds.Height < orignal.Height || Screen.PrimaryScreen.Bounds.Width < orignal.Width)
            {
                orignal = new Bitmap(orignal, Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * aspect), Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width / aspect));
            }
            work = Adjust(orignal); //fits the image inside the panel
            mouselocation = new Point();
            pictureBox1.Image = work; //shows the image in a picturebox
            pictureBox1.Location = upperleftcorner; //sets the location of the picturebox inside the panel
        }
        /* Adjust the image size according to the panel size
         * while keeping the ratio between width and height
         */
        Bitmap Adjust(Bitmap image)
        {
            Bitmap output = new Bitmap(image.Width, image.Height);
            if (output.Width > panel6.ClientSize.Width || output.Height > panel6.ClientSize.Height)
            {
                if (output.Height > output.Width)
                {
                    if (output.Height > panel6.ClientSize.Height) output = new Bitmap(Convert.ToInt32(panel6.ClientSize.Height * aspect), panel6.ClientSize.Height);
                    if (output.Width > panel6.ClientSize.Width) output = new Bitmap(panel6.ClientSize.Width, Convert.ToInt32(panel6.ClientSize.Width / aspect));
                }
                else if (output.Height < output.Width)
                {
                    if (output.Width > panel6.ClientSize.Width) output = new Bitmap(panel6.ClientSize.Width, Convert.ToInt32(panel6.ClientSize.Width / aspect));
                    if (output.Height > panel6.ClientSize.Height) output = new Bitmap(Convert.ToInt32(panel6.ClientSize.Height * aspect), panel6.ClientSize.Height);
                }
                else
                {
                    if (output.Height > panel6.ClientSize.Height)
                    {
                        output = new Bitmap(panel6.ClientSize.Height, panel6.ClientSize.Height);
                    }
                    else if (output.Width > panel6.ClientSize.Width)
                    {
                        output = new Bitmap(panel6.ClientSize.Width, panel6.ClientSize.Width);
                    }
                    else
                    {
                        output = new Bitmap(panel6.ClientSize.Width, panel6.ClientSize.Height);
                    }
                }
            }
            output = new Bitmap(image, output.Width, output.Height);
            return output;
        }
        /* everytime the panel's size changes the image size Adjusts according to the new size
         * everytime the sliderbar value changes the image size will adjust to fit that change
         */
        private void panel6_SizeChanged(object sender, EventArgs e)
        {
            work = Adjust(orignal);
            pictureBox1.Image = new Bitmap(work, new Size(work.Width * trackBar1.Value / 10, work.Height * trackBar1.Value / 10));
            pictureBox1.Location = upperleftcorner;
            if (pictureBox1.Image.Height > panel6.ClientSize.Height) panel6.AutoScroll = true;
            if (pictureBox1.Image.Width > panel6.ClientSize.Width) panel6.AutoScroll = true;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (panel6.VerticalScroll.Visible == true || panel6.HorizontalScroll.Visible == true))
            {
                mouselocation = new Point(e.X, e.Y);
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (panel6.VerticalScroll.Visible == true || panel6.HorizontalScroll.Visible == true))
            {
                int X = (mouselocation.X - e.X);
                int Y = (mouselocation.Y - e.Y);
                panel6.AutoScrollPosition = new Point((X - panel6.AutoScrollPosition.X),(Y - panel6.AutoScrollPosition.Y));
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (panel6.VerticalScroll.Visible == true || panel6.HorizontalScroll.Visible == true)
            {
                pictureBox1.Cursor = Cursors.Hand;
            }
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
        }
    }
}
