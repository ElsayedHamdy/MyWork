using Library.Models;
using System;
using System.Windows.Forms;
namespace Library.UserControls.Sections
{
    public partial class AddNewSections2 : UserControl
    {
        private ISaveSections callincontrol;
        public AddNewSections2(ISaveSections caller)
        {
            InitializeComponent();
            callincontrol = caller;
        }
        private void Donebtn_Click(object sender, EventArgs e)
        {
             if(validate())
            {
                label4.Visible = false;
                label6.Visible = false;
                Section section = new Section();
                section.Name = textBox1.Text;
                section.PageCount = int.Parse(textBox4.Text);
                section.Location = textBox5.Text;
                section.Date = DateTime.Today.ToShortDateString();
                section.Id = 0;
                foreach (var item in Connector.connections)
                {
                    if (item.CheckSections(section))
                    {
                        if (MessageBox.Show("You Have Already Add this Section.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK) return;
                        else return;
                    }
                }
                    callincontrol.SaveSections(section);
                ParentChanged -= AddNewSections2_ParentChanged;
                this.Dispose(true);
             }
        }
        bool validate()
        {
            bool valid = true;
            if (textBox1.Text==null||textBox1.Text==""||textBox1.Text==" ")
            {
                label6.Visible = true;
                valid = false;
            }
            else
            {
                label6.Visible = false;
            }
            if (textBox4.Text == null || textBox4.Text == "" || textBox4.Text == " ")
            {
                textBox4.Text = "0";
            }
            else
            {
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox4.Text[i]))
                    {
                        label4.Visible =  true;
                        valid = false;
                        break;
                    }
                }
                label4.Visible = false;
            }
            if (textBox5.Text == null || textBox5.Text == "" || textBox5.Text == " ")
            {
                textBox5.Text = "";
            }
            return valid;
        }
        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = fileDialog.FileName;
            }
            else
            {
                return;
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            ParentChanged -= AddNewSections2_ParentChanged;
            this.Dispose(true);
        }
        private void AddNewSections2_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != Size)
            {
                this.Size = Parent.Size;
            }
        }
    }
}
