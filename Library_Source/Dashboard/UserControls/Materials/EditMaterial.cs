using Library.Models;
using Library.UserControls.Books;
using Library.UserControls.Lectures;
using Library.UserControls.Sections;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Library.UserControls.Materials
{
    public partial class EditMaterial : UserControl,ISaveBooks,ISaveLectures,ISaveSections
    {
        IUpdate update;
        Material material;
        AddNewBooks2 book;
        AddNewLectures2 lecture;
        AddNewSections2 section;
        List<Lecture> selectedlectures;
        List<Lecture> avaliblelectures;
        List<Book> selectedbooks;
        List<Book> avaliblebooks;
        List<Section> selectedsections;
        List<Section> avaliblesections;
        public EditMaterial(Material material,IUpdate caller)
        {
            InitializeComponent();
            book = new AddNewBooks2(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            lecture = new AddNewLectures2(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            section = new AddNewSections2(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            update = caller;
            this.material = material;
            textBox1.Text = material.Name;
            avaliblelectures = new List<Lecture>();
            avaliblebooks = new List<Book>();
            avaliblesections = new List<Section>();
            selectedlectures = material.Lectures;
            selectedsections = material.Sections;
            selectedbooks = material.Books;
            Initialize();
        }
        void Initialize()
        {
            comboBox1.DataSource = avaliblelectures;
            comboBox1.DisplayMember = nameof(Lecture.Name);
            comboBox2.DataSource = avaliblebooks;
            comboBox2.DisplayMember = nameof(Book.Name);
            comboBox3.DataSource = avaliblesections;
            comboBox3.DisplayMember = nameof(Section.Name);
            lectureslist.DataSource = selectedlectures;
            lectureslist.DisplayMember = nameof(Lecture.Name);
            bookslist.DataSource = selectedbooks;
            bookslist.DisplayMember = nameof(Book.Name);
            sectionslist.DataSource = selectedsections;
            sectionslist.DisplayMember = nameof(Section.Name);
        }
        void Initialize_Lectures()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = avaliblelectures;
            comboBox1.DisplayMember = nameof(Lecture.Name);
            lectureslist.DataSource = null;
            lectureslist.DataSource = selectedlectures;
            lectureslist.DisplayMember = nameof(Lecture.Name);
            if (comboBox1.Items.Count != 0) comboBox1.SelectedIndex = 0;
        }
        void Initialize_Books()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = avaliblebooks;
            comboBox2.DisplayMember = nameof(Book.Name);
            bookslist.DataSource = null;
            bookslist.DataSource = selectedbooks;
            bookslist.DisplayMember = nameof(Book.Name);
            if (comboBox2.Items.Count != 0) comboBox2.SelectedIndex = 0;
        }
        void Initialize_Sections()
        {
            comboBox3.DataSource = null;
            comboBox3.DataSource = avaliblesections;
            comboBox3.DisplayMember = nameof(Section.Name);
            sectionslist.DataSource = null;
            sectionslist.DataSource = selectedsections;
            sectionslist.DisplayMember = nameof(Section.Name);
            if (comboBox3.Items.Count != 0) comboBox3.SelectedIndex = 0;
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bookslist.Items.Count != 0)
            {
                for (int i = 0; i < bookslist.SelectedItems.Count; i++)
                {
                    avaliblebooks.Add((Book)bookslist.SelectedItems[i]);
                    selectedbooks.Remove((Book)bookslist.SelectedItems[i]);
                }
                Initialize_Books();
            }
            else
            {
                return;
            }
        }
        private void ComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lectureslist.Items.Count != 0)
            {
                for (int i = 0; i < lectureslist.SelectedItems.Count; i++)
                {
                    avaliblelectures.Add((Lecture)lectureslist.SelectedItems[i]);
                    selectedlectures.Remove((Lecture)lectureslist.SelectedItems[i]);
                }
                Initialize_Lectures();
            }
            else
            {
                return;
            }
        }
        private void ComboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sectionslist.Items.Count != 0)
            {
                for (int i = 0; i < sectionslist.SelectedItems.Count; i++)
                {
                    avaliblesections.Add((Section)sectionslist.SelectedItems[i]);
                    selectedsections.Remove((Section)sectionslist.SelectedItems[i]);
                }
                Initialize_Sections();
            }
            else
            {
                return;
            }
        }
        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bookslist.Items.Count != 0)
            {
                bookslist.SelectedItems.Clear();
            }
            else
            {
                return;
            }
        }
        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lectureslist.Items.Count != 0)
            {
                lectureslist.SelectedItems.Clear();
            }
            else
            {
                return;
            }
        }
        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sectionslist.Items.Count != 0)
            {
                sectionslist.SelectedItems.Clear();
            }
            else
            {
                return;
            }
        }
        private void Donebtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                label6.Visible = false;
                Material material = new Material();
                material.Name = textBox1.Text;
                material.Lectures = selectedlectures;
                material.Sections = selectedsections;
                material.Books = selectedbooks;
                material.ID = this.material.ID;
                foreach (var item in Connector.connections)
                {
                    if (item.CheckMaterials(material))
                    {
                        if (MessageBox.Show("You Have Already Add this Material.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK) return;
                        else return;
                    }
                    else
                    {
                        item.UpdateMaterial(material);
                    }
                }
                update.Update();
                ParentChanged -= EditMaterial_ParentChanged;
                this.Dispose(true);
            }
        }
        public void SaveBooks(Book book)
        {
            selectedbooks.Add(book);
            Initialize_Books();
        }
        public void SaveSections(Section section)
        {
            selectedsections.Add(section);
            Initialize_Sections();
        }
        public void SaveLectures(Lecture lecture)
        {
            selectedlectures.Add(lecture);
            Initialize_Lectures();
        }
        private void Instructornewlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            book = new AddNewBooks2(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            book.Size = this.Size;
            this.Controls.Add(book);
            book.BringToFront();
        }
        bool validate()
        {
            bool valid=true;
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == null)
            {
                label6.Visible = true;
                valid = false;
            }
            else
            {
                label6.Visible = false;
            }
            return valid;
        }
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lecture = new AddNewLectures2(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            lecture.Size = this.Size;
            this.Controls.Add(lecture);
            lecture.BringToFront();
        }
        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            section = new AddNewSections2(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            section.Size = this.Size;
            this.Controls.Add(section);
            section.BringToFront();
        }
        private void ComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!selectedbooks.Contains((Book)comboBox2.SelectedItem))
            {
                selectedbooks.Add((Book)comboBox2.SelectedItem);
                avaliblebooks.Remove((Book)comboBox2.SelectedItem);
                Initialize_Books();
            }
        }
        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!selectedlectures.Contains((Lecture)comboBox1.SelectedItem))
            {
                selectedlectures.Add((Lecture)comboBox1.SelectedItem);
                avaliblelectures.Remove((Lecture)comboBox1.SelectedItem);
                Initialize_Lectures();
            }
        }
        private void ComboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!selectedsections.Contains((Section)comboBox3.SelectedItem))
            {
                selectedsections.Add((Section)comboBox3.SelectedItem);
                avaliblesections.Remove((Section)comboBox3.SelectedItem);
                Initialize_Sections();
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            ParentChanged -= EditMaterial_ParentChanged;
            this.Dispose(true);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Connector.connections[0].DeleteMaterial(material.ID);
            update.Update();
            ParentChanged -= EditMaterial_ParentChanged;
            this.Dispose(true);
        }
        private void EditMaterial_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != Size)
            {
                this.Size = Parent.Size;
            }
        }
        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bookslist.Items.Count != 0)
            {
                for (int i = 0; i < bookslist.Items.Count; i++)
                {
                    avaliblebooks.Add((Book)bookslist.Items[i]);
                    selectedbooks.Remove((Book)bookslist.Items[i]);
                }
                Initialize_Books();
            }
            else
            {
                return;
            }
        }
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lectureslist.Items.Count != 0)
            {
                for (int i = 0; i < lectureslist.Items.Count; i++)
                {
                    avaliblelectures.Add((Lecture)lectureslist.Items[i]);
                    selectedlectures.Remove((Lecture)lectureslist.Items[i]);
                }
                Initialize_Lectures();
            }
            else
            {
                return;
            }
        }
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sectionslist.Items.Count != 0)
            {
                for (int i = 0; i < sectionslist.Items.Count; i++)
                {
                    avaliblesections.Add((Section)sectionslist.Items[i]);
                    selectedsections.Remove((Section)sectionslist.Items[i]);
                }
                Initialize_Sections();
            }
            else
            {
                return;
            }
        }
    }
}
