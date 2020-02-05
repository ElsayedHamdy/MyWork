using System;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public double[] varaibles;
        public Form1()
        {
            InitializeComponent();
            varaibles = new double[3];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validate(ref varaibles))
            {
                if (varaibles[0] != 0)
                {
                    double root = Math.Pow(varaibles[1], 2) - 4 * varaibles[0] * varaibles[2];
                    if (root == Math.Abs(root))
                    {
                        txt_rx2.Text = ((-varaibles[1] - Math.Sqrt(root)) / (2 * varaibles[0])).ToString();
                        txt_rx1.Text = ((-varaibles[1] + Math.Sqrt(root)) / (2 * varaibles[0])).ToString();
                    }
                    else
                    {
                        txt_rx2.Text = (-varaibles[1] / (2 * varaibles[0])).ToString() + " - " + (Math.Sqrt(-root) / (2 * varaibles[0])).ToString() + "i";
                        txt_rx1.Text = (-varaibles[1] / (2 * varaibles[0])).ToString() + " + " + (Math.Sqrt(-root) / (2 * varaibles[0])).ToString() + "i";
                    }
                }
                else
                {
                    txt_rx2.Text = "";
                    txt_rx1.Text = (-varaibles[2] / varaibles[1]).ToString();
                }
            }
            else
            {
                MessageBox.Show("Syntax Error");
            }
        }
        public bool validate (ref double[]variables)
            {
            if (double.TryParse(txt_xP1.Text, out varaibles[0])) ;
            else return false;
            if (double.TryParse(txt_xP2.Text, out varaibles[1])) ;
            else return false;
            if (double.TryParse(txt_c.Text, out varaibles[2])) ;
            else return false;
            return true;
            }
        private void txt_rx1_TextChanged(object sender, EventArgs e)
        {
            txt_rx2.Size = TextRenderer.MeasureText(txt_rx2.Text, txt_rx2.Font);
            txt_rx1.Size = TextRenderer.MeasureText(txt_rx1.Text, txt_rx1.Font);
            if (txt_rx1.Location.X + txt_rx1.Size.Width >= btn_solve.Location.X || txt_rx2.Location.X + txt_rx2.Size.Width >= btn_solve.Location.X)
            {
                if (txt_rx1.Size.Width >= txt_rx2.Size.Width) this.Width += (txt_rx1.Location.X + txt_rx1.Size.Width) - btn_solve.Location.X + 3;
                else this.Width += (txt_rx2.Location.X + txt_rx2.Size.Width) - btn_solve.Location.X + 3;
            }
            else
            {
                if (txt_rx1.Size.Width >= txt_rx2.Size.Width) this.Width -= btn_solve.Location.X - (txt_rx1.Location.X + txt_rx1.Size.Width);
                else this.Width -= btn_solve.Location.X - (txt_rx2.Location.X + txt_rx2.Size.Width);
                if (this.Width < 420) this.Width = 420;
            }
        }
    }
}
