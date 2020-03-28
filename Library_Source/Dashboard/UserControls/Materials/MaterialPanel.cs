using Library.Models;
using Library.UserControls.Books;
using Library.UserControls.Courses;
using Library.UserControls.Instructors;
using Library.UserControls.Lectures;
using Library.UserControls.Sections;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library.UserControls.Materials
{
    public partial class MaterialPanel : UserControl,IExitAddNewMaterial,IEditMaterial,IUpdate
    {
        IUpdate update;
        int _id;
        string _who;
        bool searched;
        AddNewMaterial newmaterial;
        List<Material> materials;
        List<Material> searchmaterials;
        List<MaterialDataPanel> materialdatas;
        public MaterialPanel()
        {
            InitializeComponent();
            materialdatas = new List<MaterialDataPanel>();
            newmaterial = new AddNewMaterial(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            materials = Task.Run(() => Connector.connections[0].GetMaterials()).Result;
            Initialize();
        }
        public MaterialPanel(int id, string who,IUpdate update)
        {
            InitializeComponent();
            materialdatas = new List<MaterialDataPanel>();
            this.update = update;
            _id = id;
            _who = who;
            searchbox.Enabled = false;
            searchbtn.Enabled = false;
            this.addnewmaterialbtn.Click += new System.EventHandler(this.close_Click);
            this.addnewmaterialbtn.Text = "Close";
            switch (who)
            {
                case "instructor":
                    materials = Task.Run(() => Connector.connections[0].GetMaterialByInstructor(id)).Result;
                    Initialize();
                    break;
                case "course":
                    materials = Task.Run(() => Connector.connections[0].GetMaterialByCourse(id)).Result;
                    Initialize();
                    break;
                default:
                    ParentChanged -= MaterialPanel_ParentChanged;
                    this.Dispose(true);
                    break;
            }
        }
        async void Initialize()
        {
            searched = false;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            panel1.Controls.Clear();
            materialdatas.Clear();
            panel1.SuspendLayout();
           await Task.Run(() =>
            {
                if (materials.Count >= 7)
                {
                    for (int i = 0; i < materials.Count; i++)
                    {
                        MaterialDataPanel panel = new MaterialDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = materials[i].Name;
                        panel.secnolb.Text += materials[i].NumberOfSections;
                        panel.pagenolb.Text += materials[i].NumberOfBooks;
                        panel.lecnolb.Text += materials[i].NumberOfLectures;
                        panel.Width = 764;
                        materialdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < materials.Count; i++)
                    {
                        var panel = new MaterialDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = materials[i].Name;
                        panel.secnolb.Text += materials[i].NumberOfSections;
                        panel.pagenolb.Text += materials[i].NumberOfBooks;
                        panel.lecnolb.Text += materials[i].NumberOfLectures;
                        panel.Width = 781;
                        materialdatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(materialdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Addcinstructorbtn_Click(object sender, EventArgs e)
        {
            newmaterial = new AddNewMaterial(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newmaterial.Size = this.Size;
            this.Controls.Add(newmaterial);
            newmaterial.BringToFront();
        }
        public void ExitAddNewMaterial(Material material)
        {
            materials.Add(material);
            Initialize();
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") return;
            else
            {
                SearchInitialize(searchbox.Text.TrimStart().TrimEnd());
                searchmaterials.Clear();
            }
        }
       void SearchInitialize(string Name)
        {
            searched = true;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            searchmaterials = Task.Run(() => Connector.connections[0].SearchMaterials(Name)).Result;
            panel1.Controls.Clear();
            materialdatas.Clear();
            panel1.SuspendLayout();
           Task.Run(() =>
            {
                if (searchmaterials.Count >= 7)
                {
                    for (int i = 0; i < searchmaterials.Count; i++)
                    {
                        var panel = new MaterialDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchmaterials[i].Name;
                        panel.secnolb.Text += searchmaterials[i].NumberOfSections;
                        panel.pagenolb.Text += searchmaterials[i].NumberOfBooks;
                        panel.lecnolb.Text += searchmaterials[i].NumberOfLectures;
                        panel.Width = 764;
                        materialdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < searchmaterials.Count; i++)
                    {
                        var panel = new MaterialDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchmaterials[i].Name;
                        panel.secnolb.Text += searchmaterials[i].NumberOfSections;
                        panel.pagenolb.Text += searchmaterials[i].NumberOfBooks;
                        panel.lecnolb.Text += searchmaterials[i].NumberOfLectures;
                        panel.Width = 781;
                        materialdatas.Add(panel);
                    }
                }
            }).Wait();
            panel1.Controls.AddRange(materialdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            if (searchbox.Text == "" && searched)
            {
                Initialize();
            }
            else
            {
                return;
            }
        }
        private void Searchbox_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") searchbox.Text = "";
        }
        public void EditMaterial(MaterialDataPanel caller)
        {
            var calling = new EditMaterial(Connector.connections[0].GetMaterial(materials[panel1.Controls.IndexOf(caller)].ID), this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            calling.Size = this.Size;
            this.Controls.Add(calling);
            calling.BringToFront();
        }
        new public void Update()
        {
            if (_id != 0)
            {
                switch (_who)
                {
                    case "instructor":
                        materials = Task.Run(() => Connector.connections[0].GetMaterialByInstructor(_id)).Result;
                        Initialize();
                        break;
                    case "course":
                        materials = Task.Run(() => Connector.connections[0].GetMaterialByCourse(_id)).Result;
                        Initialize();
                        break;
                    default:
                        ParentChanged -= MaterialPanel_ParentChanged;
                        this.Dispose(true);
                        break;
                }
            }
            else
            {
                materials = Task.Run(() => Connector.connections[0].GetMaterials()).Result;
                Initialize();
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            update.Update();
            ParentChanged -= MaterialPanel_ParentChanged;
            this.Dispose(true);
        }
        public void Open(object caller, string who)
        {
            switch (who)
            {
                case "lecture":
                    var calling = new LecturesPanel(Connector.connections[0].GetMaterial(materials[panel1.Controls.IndexOf((MaterialDataPanel)caller)].ID).ID, "material",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling.Size = this.Size;
                    this.Controls.Add(calling);
                    calling.BringToFront();
                    break;
                case "section":
                    var calling1 = new SectionsPanel(Connector.connections[0].GetMaterial(materials[panel1.Controls.IndexOf((MaterialDataPanel)caller)].ID).ID, "material",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling1.Size = this.Size;
                    this.Controls.Add(calling1);
                    calling1.BringToFront();
                    break;
                case "book":
                    var calling2 = new BooksPanel(Connector.connections[0].GetMaterial(materials[panel1.Controls.IndexOf((MaterialDataPanel)caller)].ID).ID, "material",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling2.Size = this.Size;
                    this.Controls.Add(calling2);
                    calling2.BringToFront();
                    break;
                case "instructor":
                    var calling3 = new InstructorPanel(Connector.connections[0].GetMaterial(materials[panel1.Controls.IndexOf((MaterialDataPanel)caller)].ID).ID, "material",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling3.Size = this.Size;
                    this.Controls.Add(calling3);
                    calling3.BringToFront();
                    break;
                case "course":
                    var calling4 = new CoursePanel(Connector.connections[0].GetMaterial(materials[panel1.Controls.IndexOf((MaterialDataPanel)caller)].ID).ID, "material",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling4.Size = this.Size;
                    this.Controls.Add(calling4);
                    calling4.BringToFront();
                    break;
            }
        }
        private void MaterialPanel_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != Size)
            {
                this.Size = Parent.Size;
            }
        }
        public void _update()
        {
            materials = Task.Run(() => Connector.connections[0].GetMaterials()).Result;
            Initialize();
        }
        private void searchbox_Validated(object sender, EventArgs e)
        {
            if(searchbox.Text == "") searchbox.Text = "Search Here!";
        }
        private void materialspl_Click(object sender, EventArgs e)
        {
            materialspl.Focus();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
