using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library.UserControls.Sections
{
    public partial class SectionsPanel : UserControl,ISaveSections,IEditSection,IUpdate
    {
        IUpdate update;
        int _id;
        string _who;
        bool searched;
        AddNewSections newsections;
        List<Section> sections;
        List<Section> searchsections;
        List<SectionsDataPanel> sectionsdatas;
        public SectionsPanel()
        {
            InitializeComponent();
            sectionsdatas = new List<SectionsDataPanel>();
            newsections = new AddNewSections(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            sections = Task.Run(() => Connector.connections[0].GetSections()).Result;
            Initialize();
        }
        public SectionsPanel(int id, string who,IUpdate update)
        {
            InitializeComponent();
            sectionsdatas = new List<SectionsDataPanel>();
            this.update = update;
            _id = id;
            _who = who;
            searchbox.Enabled = false;
            searchbtn.Enabled = false;
            this.addcinstructorbtn.Click += new System.EventHandler(this.close_Click);
            addcinstructorbtn.Text = "Close";
            switch (who)
            {
                case "instructor":
                    sections = Task.Run(() => Connector.connections[0].GetSectionsByInstructor(id)).Result;
                    Initialize();
                    break;
                case "material":
                    sections = Task.Run(() => Connector.connections[0].GetSectionsByMaterial(id)).Result;
                    Initialize();
                    break;
                case "course":
                    sections = Task.Run(() => Connector.connections[0].GetSectionsByCourse(id)).Result;
                    Initialize();
                    break;
                default:
                    ParentChanged -= SectionsPanel_ParentChanged;
                    this.Dispose(true);
                    break;
            }
        }
        async void Initialize()
        {
            searched = false;
            pictureBox1.Visible = false;
            panel1.Enabled = true;
            panel1.Controls.Clear();
            sectionsdatas.Clear();
            panel1.SuspendLayout();
           await Task.Run(() =>
            {
                if (sections.Count >= 7)
                {
                    for (int i = 0; i < sections.Count; i++)
                    {
                        SectionsDataPanel panel = new SectionsDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = sections[i].Name;
                        panel.pagecountlb.Text += sections[i].PageCount.ToString();
                        panel.datelb.Text += sections[i].Date;
                        panel.Width = 764;
                        sectionsdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < sections.Count; i++)
                    {
                        var panel = new SectionsDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = sections[i].Name;
                        panel.pagecountlb.Text += sections[i].PageCount.ToString();
                        panel.datelb.Text += sections[i].Date;
                        panel.Width = 781;
                        sectionsdatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(sectionsdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Addcinstructorbtn_Click(object sender, EventArgs e)
        {
            newsections = new AddNewSections(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newsections.Size = this.Size;
            this.Controls.Add(newsections);
            newsections.BringToFront();
        }
        public void SaveSections(Section section)
        {
            sections.Add(section);
            Initialize();
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
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") return;
            else
            {
                SearchInitialize(searchbox.Text.TrimStart().TrimEnd());
                searchsections.Clear();
            }
        }
       async void SearchInitialize(string Name)
        {
            searched = true;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            searchsections = Task.Run(() => Connector.connections[0].SearchSections(Name)).Result;
            panel1.Controls.Clear();
            sectionsdatas.Clear();
            panel1.SuspendLayout();
           await Task.Run(() =>
            {
                if (searchsections.Count >= 7)
                {
                    for (int i = 0; i < searchsections.Count; i++)
                    {
                        SectionsDataPanel panel = new SectionsDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchsections[i].Name;
                        panel.pagecountlb.Text += searchsections[i].PageCount.ToString();
                        panel.datelb.Text += searchsections[i].Date;
                        panel.Width = 764;
                        sectionsdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < searchsections.Count; i++)
                    {
                        var panel = new SectionsDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchsections[i].Name;
                        panel.pagecountlb.Text += searchsections[i].PageCount.ToString();
                        panel.datelb.Text += searchsections[i].Date;
                        panel.Width = 781;
                        sectionsdatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(sectionsdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        new public void Update()
        {
            if (_id != 0)
            {
                switch (_who)
                {
                    case "instructor":
                        sections = Task.Run(() => Connector.connections[0].GetSectionsByInstructor(_id)).Result;
                        Initialize();
                        break;
                    case "material":
                        sections = Task.Run(() => Connector.connections[0].GetSectionsByMaterial(_id)).Result;
                        Initialize();
                        break;
                    case "course":
                        sections = Task.Run(() => Connector.connections[0].GetSectionsByCourse(_id)).Result;
                        Initialize();
                        break;
                    default:
                        ParentChanged -= SectionsPanel_ParentChanged;
                        this.Dispose(true);
                        break;
                }
            }
            else
            {
                sections = Task.Run(() => Connector.connections[0].GetSections()).Result;
                Initialize();
            }
        }
        public void EditSection(SectionsDataPanel caller)
        {
            var calling = new EditSections(Connector.connections[0].GetSection(sections[panel1.Controls.IndexOf(caller)].Id), this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            calling.Size = this.Size;
            this.Controls.Add(calling);
            calling.BringToFront();
        }
        private void close_Click(object sender, EventArgs e)
        {
            update.Update();
            ParentChanged -= SectionsPanel_ParentChanged;
            this.Dispose(true);
        }
        public void Open(object caller, string who)
        {
            Section section = Connector.connections[0].GetSection(sections[panel1.Controls.IndexOf((SectionsDataPanel)caller)].Id);
            if (File.Exists(section.Location))
            {
                System.Diagnostics.Process.Start(@section.Location);
            }
            else
            {
                MessageBox.Show("File Doesn't Exists\n" +
                    @section.Location, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SectionsPanel_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != Size)
            {
                this.Size = Parent.Size;
            }
        }
        public void _update()
        {
            sections = Task.Run(() => Connector.connections[0].GetSections()).Result;
            Initialize();
        }
        private void searchbox_Validated(object sender, EventArgs e)
        {
            if(searchbox.Text == "") searchbox.Text = "Search Here!";
        }
        private void sectionspl_Click(object sender, EventArgs e)
        {
            sectionspl.Focus();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
