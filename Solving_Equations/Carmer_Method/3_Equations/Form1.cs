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
            varaibles = new double[12];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validate(ref varaibles))
            {
                double d   =  varaibles[0] * (varaibles[5] * varaibles[10] - varaibles[6] * varaibles[9]) 
                    - varaibles[1] * ( varaibles[4] * varaibles[10] - varaibles[6] * varaibles[8]) 
                    + varaibles[2] * (varaibles[4] * varaibles[9] - varaibles[5] * varaibles[8]);
                double d_x = varaibles[3] * (varaibles[5] * varaibles[10] - varaibles[6] * varaibles[9])
                    - varaibles[1] * (varaibles[7] * varaibles[10] - varaibles[6] * varaibles[11])
                    + varaibles[2] * (varaibles[7] * varaibles[9] - varaibles[5] * varaibles[11]);
                double d_y = varaibles[0] * (varaibles[7] * varaibles[10] - varaibles[6] * varaibles[11])
                    - varaibles[3] * (varaibles[4] * varaibles[10] - varaibles[6] * varaibles[8])
                    + varaibles[2] * (varaibles[4] * varaibles[11] - varaibles[7] * varaibles[8]);
                double d_z = varaibles[0] * (varaibles[5] * varaibles[11] - varaibles[7] * varaibles[9])
                    - varaibles[1] * (varaibles[4] * varaibles[11] - varaibles[7] * varaibles[8])
                    + varaibles[3] * (varaibles[4] * varaibles[9] - varaibles[5] * varaibles[8]);
                switch (d)
                {
                    case 0:
                        MessageBox.Show("Math Error");
                        break;
                    default:
                        txt_rz.Text = (d_z / d).ToString();
                        txt_ry.Text = (d_y / d).ToString();
                        txt_rx.Text = (d_x / d).ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Syntax Error");
            }
        }
        public bool validate (ref double[]variables)
            {
                if (double.TryParse(txt_x.Text, out varaibles[0])) ;
                else return false;
                if (double.TryParse(txt_y.Text, out varaibles[1])) ;
                else return false;
                if (double.TryParse(txt_z.Text, out varaibles[2])) ;
                else return false;
                if (double.TryParse(txt_c1.Text, out varaibles[3])) ;
                else return false;
                if (double.TryParse(txt_x2.Text, out varaibles[4])) ;
                else return false;
                if (double.TryParse(txt_y2.Text, out varaibles[5])) ;
                else return false;
                if (double.TryParse(txt_z2.Text, out varaibles[6])) ;
                else return false;
                if (double.TryParse(txt_c2.Text, out varaibles[7])) ;
                else return false;
                if (double.TryParse(txt_x3.Text, out varaibles[8])) ;
                else return false;
                if (double.TryParse(txt_y3.Text, out varaibles[9])) ;
                else return false;
                if (double.TryParse(txt_z3.Text, out varaibles[10])) ;
                else return false;
                if (double.TryParse(txt_c3.Text, out varaibles[11])) ;
                else return false;
            return true;
            }
        private void txt_rx_TextChanged(object sender, EventArgs e)
        {
            txt_rx.Size = TextRenderer.MeasureText(txt_rx.Text, txt_rx.Font);
            txt_ry.Size = TextRenderer.MeasureText(txt_ry.Text, txt_ry.Font);
            txt_rz.Size = TextRenderer.MeasureText(txt_rz.Text, txt_rz.Font);
            if (txt_rx.Location.X + txt_rx.Size.Width >= btn_solve.Location.X || txt_ry.Location.X + txt_ry.Size.Width >= btn_solve.Location.X || txt_rz.Location.X + txt_rz.Size.Width >= btn_solve.Location.X)
            {
                if (txt_rx.Size.Width >= txt_ry.Size.Width && txt_rx.Size.Width >= txt_rz.Size.Width) this.Width += (txt_rx.Location.X + txt_rx.Size.Width) - btn_solve.Location.X + 3;
                else if(txt_ry.Size.Width >= txt_rz.Size.Width) this.Width += (txt_ry.Location.X + txt_ry.Size.Width) - btn_solve.Location.X + 3;
                else  this.Width += (txt_rz.Location.X + txt_rz.Size.Width) - btn_solve.Location.X + 3;
            }
            else 
            {
                if (txt_rx.Size.Width >= txt_ry.Size.Width && txt_rx.Size.Width >= txt_rz.Size.Width) this.Width -= btn_solve.Location.X - (txt_rx.Location.X + txt_rx.Size.Width);
                else if (txt_ry.Size.Width >= txt_rz.Size.Width) this.Width -= btn_solve.Location.X - (txt_ry.Location.X + txt_ry.Size.Width);
                else this.Width -= btn_solve.Location.X - (txt_rz.Location.X + txt_rz.Size.Width);
                if (this.Width < 455) this.Width = 455;
            }
        }
    }
}
