using Library.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Library.UserControls.Books
{
    public partial class AddNewBooks : UserControl
    {
        private ISaveBooks callingcontrol;
        private List<Material> materials = Connector.connections[0].GetMaterials();
        List<string> selectedauthors;
        public AddNewBooks(ISaveBooks caller)
        {
            InitializeComponent();
            wireup();
            callingcontrol = caller;
            selectedauthors = new List<string>();
        }
        private void Donebtn_Click(object sender, EventArgs e)
        {
             if(validate())
            {
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                errormaterialnamelb.Visible = false;
                Book book = new Book();
                Material material = new Material();
                book.Name = textBox1.Text;
                book.Publisher = textBox2.Text;
                book.ChapterCount = int.Parse(textBox3.Text);
                book.PageCount = int.Parse(textBox4.Text);
                book.Location = textBox5.Text;
                if (selectedauthors.Count == 0) selectedauthors.Add("Unkown Author");
                book.Authors = selectedauthors;
                book.Date = DateTime.Today.ToShortDateString();
                material = (Material)comboBox3.SelectedItem;
                foreach (var item in Connector.connections)
                {
                    if (item.CheckBooks(book))
                    {
                        if (MessageBox.Show("You Have Already Add this Book.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK) return;
                        else return;
                    }
                    else
                    {
                        book = item.CreateBook(book,material.ID);
                    }
                }
                callingcontrol.SaveBooks(book);
                ParentChanged -= AddNewBooks_ParentChanged;
                this.Dispose(true);
            }
        }
        void wireup()
        {
            comboBox3.DataSource = null;
            comboBox3.DataSource = materials;
            comboBox3.DisplayMember = nameof(Material.Name);
        }
        bool validate()
        {
            bool valid = true;
            if (comboBox3.SelectedItem == null)
            {
                errormaterialnamelb.Visible = true;
                valid = false;
            }
            else
            {
                errormaterialnamelb.Visible = false;
            }
            if (textBox1.Text==null||textBox1.Text==""||textBox1.Text==" ")
            {
                label6.Visible = true;
                valid = false;
            }
            else
            {
                label6.Visible = false;
            }
            if (textBox2.Text == null || textBox2.Text == "" || textBox2.Text == " " || textBox2.Text.Trim()==textBox2.Text)
            {
                textBox2.Text = "Unkown Publisher";
            }
           if (textBox3.Text == null || textBox3.Text == "" || textBox3.Text == " ")
            {
                textBox3.Text = "0";
            }
            else
            {
                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox3.Text[i]))
                    {
                        label3.Visible = true;
                        valid = false;
                        break;
                    }
                }
                label3.Visible = false;
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
            if (authorslist.Items.Count==0)
            {
                selectedauthors.Add("Unkown Author");
            }
            else
            {
                selectedauthors.Remove("Unkown Author");
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
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox6.Text == "" || textBox6.Text == " " || textBox6.Text == null)
            {
                textBox6.Text = "";
            }
            else if (authorslist.Items.Contains(textBox6.Text))
            {
                return;
            }
            else
            {
                authorslist.Items.Add(textBox6.Text);
                selectedauthors.Add(textBox6.Text);
                textBox6.Text = "";
            }
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (authorslist.Items != null)
            {
                for (int i = 0; i < authorslist.SelectedItems.Count; i++)
                {
                    selectedauthors.Remove(authorslist.SelectedItems[i].ToString());
                    authorslist.Items.Remove(authorslist.SelectedItems[i]);
                }
            }
            else
            {
                return;
            }
        }
        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (authorslist.SelectedItems != null)
            {
                authorslist.ClearSelected();
            }
            else
            {
                return;
            }
        }
        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            ParentChanged -= AddNewBooks_ParentChanged;
            this.Dispose(true);
        }
        private void AddNewBooks_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != Size)
            {
                this.Size = Parent.Size;
            }
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (authorslist.Items != null)
            {
                selectedauthors.Clear();
                authorslist.Items.Clear();
            }
            else
            {
                return;
            }
        }
    }
}
