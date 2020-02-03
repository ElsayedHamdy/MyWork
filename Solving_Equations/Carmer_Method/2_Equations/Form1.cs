using System;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public decimal[] varaibles;
        public Form1()
        {
            InitializeComponent();
            varaibles = new decimal[6];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validate(ref varaibles))
            {
                decimal d   = varaibles[0] * varaibles[4] - varaibles[1] * varaibles[3];
                decimal d_x = varaibles[2] * varaibles[4] - varaibles[1] * varaibles[5];
                decimal d_y = varaibles[0] * varaibles[5] - varaibles[2] * varaibles[3];
                switch (d)
                {
                    case 0:
                        MessageBox.Show("Math Error");
                        break;
                    default:
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
        public bool validate (ref decimal[]variables)
            {
                if (decimal.TryParse(txt_x.Text, out varaibles[0])) ;
                else return false;
                if (decimal.TryParse(txt_y.Text, out varaibles[1])) ;
                else return false;
                if (decimal.TryParse(txt_c1.Text, out varaibles[2])) ;
                else return false;
                if (decimal.TryParse(txt_x2.Text, out varaibles[3])) ;
                else return false;
                if (decimal.TryParse(txt_y2.Text, out varaibles[4])) ;
                else return false;
                if (decimal.TryParse(txt_c2.Text, out varaibles[5])) ;
                else return false;
            return true;
            }
        private void txt_rx_TextChanged(object sender, EventArgs e)
        {
            txt_rx.Size = TextRenderer.MeasureText(txt_rx.Text, txt_rx.Font);
            txt_ry.Size = TextRenderer.MeasureText(txt_ry.Text, txt_ry.Font);
            if (txt_rx.Location.X + txt_rx.Size.Width >= btn_solve.Location.X || txt_ry.Location.X + txt_ry.Size.Width >= btn_solve.Location.X)
            {
                if (txt_rx.Size.Width >= txt_ry.Size.Width) this.Width += (txt_rx.Location.X + txt_rx.Size.Width) - btn_solve.Location.X + 3;
                else this.Width += (txt_ry.Location.X + txt_ry.Size.Width) - btn_solve.Location.X + 3;
            }
            else 
            {
                if (txt_rx.Size.Width >= txt_ry.Size.Width) this.Width -= btn_solve.Location.X - (txt_rx.Location.X + txt_rx.Size.Width);
                else this.Width -= btn_solve.Location.X - (txt_ry.Location.X + txt_ry.Size.Width);
                if (this.Width < 334) this.Width = 334;
            }
        }
    }
}
