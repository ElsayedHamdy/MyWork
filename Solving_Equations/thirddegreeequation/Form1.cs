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
            varaibles = new double[4];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (validate(ref varaibles))
            {
                if (varaibles[0] != 0)
                {
                    double p = (3 * varaibles[0] * varaibles[2] - Math.Pow(varaibles[1], 2)) / (3 * Math.Pow(varaibles[0],2));
                    double q = (2 * Math.Pow(varaibles[1], 3) - 9 * varaibles[0] * varaibles[1] * varaibles[2] + 27 * Math.Pow(varaibles[0], 2) * varaibles[3]) / (27 * Math.Pow(varaibles[0],3));
                    double r = -varaibles[1] / (3 * varaibles[0]);
                    double d = Math.Pow(q / 2, 2) + Math.Pow(p / 3,3);
                    double x, u, v;
                    if (- (4 * Math.Pow(p,3) + 27 * Math.Pow(q,2)) < 0)
                    {
                        u = (-q / 2 + Math.Sqrt(d) > 0) ? Math.Pow(-q / 2 + Math.Sqrt(d), (double)1 / 3) : -Math.Pow(-(-q / 2 + Math.Sqrt(d)), (double)1 / 3);
                        v = (-q / 2 - Math.Sqrt(d) > 0) ? Math.Pow(-q / 2 - Math.Sqrt(d), (double)1 / 3) : -Math.Pow(-(-q / 2 - Math.Sqrt(d)), (double)1 / 3);
                        x = u + v + r;
                        txt_rx3.Text = (u>v) ? ((u+v) * -0.5 + r).ToString() + " - " + ((-(-u + v) * Math.Sqrt(3)) / 2).ToString() + "i": ((u + v) * -0.5 + r).ToString() + " + " + (((-u + v) * Math.Sqrt(3)) / 2).ToString() + "i";
                        txt_rx2.Text = (v>u) ? ((u+v) * -0.5 + r).ToString() + " - " + ((-(-v + u) * Math.Sqrt(3)) / 2).ToString() + "i": ((u + v) * -0.5 + r).ToString() + " + " + (((-v + u) * Math.Sqrt(3)) / 2).ToString() + "i";
                        txt_rx1.Text = x.ToString();
                    }
                    else if(-(4 * Math.Pow(p, 3) + 27 * Math.Pow(q, 2)) == 0)
                    {
                        if (Math.Pow(varaibles[1],2) == 3 * varaibles[0] * varaibles[2])
                        {
                            txt_rx3.Text = (-varaibles[1] / (3 * varaibles[0])).ToString();
                            txt_rx2.Text = (-varaibles[1] / (3 * varaibles[0])).ToString();
                            txt_rx1.Text = (-varaibles[1] / (3 * varaibles[0])).ToString();
                        }
                        else
                        {
                            txt_rx3.Text = ((9 * varaibles[0] * varaibles[3] - varaibles[1] * varaibles[2]) / (2 * (Math.Pow(varaibles[1], 2) - 3 * varaibles[0] * varaibles[2]))).ToString();
                            txt_rx2.Text = ((9 * varaibles[0] * varaibles[3] - varaibles[1] * varaibles[2]) / (2 * (Math.Pow(varaibles[1], 2) - 3 * varaibles[0] * varaibles[2]))).ToString();
                            txt_rx1.Text = ((4 * varaibles[0] * varaibles[1] * varaibles[2] - 9 * Math.Pow(varaibles[0], 2) * varaibles[3] - Math.Pow(varaibles[1], 3)) / (varaibles[0] * (Math.Pow(varaibles[1], 2) - 3 * varaibles[0] * varaibles[2]))).ToString();
                        }
                    }
                    else 
                    {
                        txt_rx3.Text = (2 * Math.Sqrt(-p / 3) * Math.Cos(Math.Acos(((3 * q) / (2 * p)) * Math.Sqrt(-3 / p)) / 3 - ((2 * Math.PI * 2) / 3)) + r).ToString();
                        txt_rx2.Text = (2 * Math.Sqrt(-p / 3) * Math.Cos(Math.Acos(((3 * q) / (2 * p)) * Math.Sqrt(-3 / p)) / 3 - ((2 * Math.PI * 1) / 3)) + r).ToString();
                        txt_rx1.Text = (2 * Math.Sqrt(-p / 3) * Math.Cos(Math.Acos(((3 * q) / (2 * p)) * Math.Sqrt(-3 / p)) / 3 - ((2 * Math.PI * 0) / 3)) + r).ToString();
                        //txt_rx3.Text = (2 * Math.Pow(Math.Sqrt(Math.Pow(-q / 2, 2) - d), (double) 1 / 3) * Math.Cos(Math.Atan(Math.Sqrt(-d) / (-q / 2)) / 3 + (2 * Math.PI * 2) / 3) + r).ToString();
                        //txt_rx2.Text = (2 * Math.Pow(Math.Sqrt(Math.Pow(-q / 2, 2) - d), (double) 1 / 3) * Math.Cos(Math.Atan(Math.Sqrt(-d) / (-q / 2)) / 3 + (2 * Math.PI * 1) / 3) + r).ToString();
                        //txt_rx1.Text = (2 * Math.Pow(Math.Sqrt(Math.Pow(-q / 2, 2) - d), (double) 1 / 3) * Math.Cos(Math.Atan(Math.Sqrt(-d) / (-q / 2)) / 3 + (2 * Math.PI * 0) / 3)) + r).ToString();
                    }
                }
                else
                {
                    if (varaibles[1] != 0)
                    {
                        double root = Math.Pow(varaibles[2], 2) - 4 * varaibles[1] * varaibles[3];
                        if (root == Math.Abs(root))
                        {
                            txt_rx2.Text = ((-varaibles[2] - Math.Sqrt(root)) / (2 * varaibles[1])).ToString();
                            txt_rx1.Text = ((-varaibles[2] + Math.Sqrt(root)) / (2 * varaibles[1])).ToString();
                        }
                        else
                        {
                            txt_rx2.Text = (-varaibles[2] / (2 * varaibles[1])).ToString() + " - " + (Math.Sqrt(-root) / (2 * varaibles[1])).ToString() + "i";
                            txt_rx1.Text = (-varaibles[2] / (2 * varaibles[1])).ToString() + " + " + (Math.Sqrt(-root) / (2 * varaibles[1])).ToString() + "i";
                        }
                    }
                    else
                    {
                        if (varaibles[2] != 0)
                        {
                            txt_rx3.Text = "";
                            txt_rx2.Text = "";
                            txt_rx1.Text = (-varaibles[3] / varaibles[2]).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Math Error");
                        }
                    }
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
            if (double.TryParse(txt_xP3.Text, out varaibles[2])) ;
            else return false;
            if (double.TryParse(txt_c.Text, out varaibles[3])) ;
            else return false;
            return true;
            }
        private void txt_rx1_TextChanged(object sender, EventArgs e)
        {
            txt_rx3.Size = TextRenderer.MeasureText(txt_rx3.Text, txt_rx3.Font);
            txt_rx2.Size = TextRenderer.MeasureText(txt_rx2.Text, txt_rx2.Font);
            txt_rx1.Size = TextRenderer.MeasureText(txt_rx1.Text, txt_rx1.Font);
            if (txt_rx1.Location.X + txt_rx1.Size.Width >= btn_solve.Location.X || txt_rx2.Location.X + txt_rx2.Size.Width >= btn_solve.Location.X || txt_rx3.Location.X + txt_rx3.Size.Width >= btn_solve.Location.X)
            {
                if (txt_rx1.Size.Width >= txt_rx2.Size.Width && txt_rx1.Size.Width >= txt_rx3.Size.Width) this.Width += (txt_rx1.Location.X + txt_rx1.Size.Width) - btn_solve.Location.X + 3;
                else if(txt_rx2.Size.Width >= txt_rx3.Size.Width) this.Width += (txt_rx2.Location.X + txt_rx2.Size.Width) - btn_solve.Location.X + 3;
                else this.Width += (txt_rx3.Location.X + txt_rx3.Size.Width) - btn_solve.Location.X + 3;
            }
            else
            {
                if (txt_rx1.Size.Width >= txt_rx2.Size.Width && txt_rx1.Size.Width >= txt_rx3.Size.Width) this.Width -= btn_solve.Location.X - (txt_rx1.Location.X + txt_rx1.Size.Width);
                else if (txt_rx2.Size.Width >= txt_rx3.Size.Width) this.Width -= btn_solve.Location.X - (txt_rx2.Location.X + txt_rx2.Size.Width);
                else this.Width -= btn_solve.Location.X - (txt_rx3.Location.X + txt_rx3.Size.Width);
                if (this.Width < 560) this.Width = 560;
            }
        }
    }
}
