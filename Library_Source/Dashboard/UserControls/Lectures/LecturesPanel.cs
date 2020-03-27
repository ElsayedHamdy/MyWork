using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library.UserControls.Lectures
{
    public partial class LecturesPanel : UserControl,ISaveLectures,IEditLecture,IUpdate
    {
        IUpdate update;
        int _id;
        string _who;
        bool searched;
        List<Lecture> lectures;
        List<Lecture> searchlectures;
        AddNewLectures newlectures;
        List<LecturesDataPanel> lecturesdatas;
        public LecturesPanel()
        {
            InitializeComponent();
            lecturesdatas = new List<LecturesDataPanel>();
            newlectures = new AddNewLectures(this);
            lectures = Task.Run(() => Connector.connections[0].GetLectures()).Result;
            Initialize();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        public LecturesPanel(int id,string who,IUpdate update)
        {
            InitializeComponent();
            lecturesdatas = new List<LecturesDataPanel>();
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
                    lectures = Task.Run(() => Connector.connections[0].GetLecturesByInstructor(id)).Result;
                    Initialize();
                    break;
                case "material":
                    lectures = Task.Run(() => Connector.connections[0].GetLecturesByMaterial(id)).Result;
                    Initialize();
                    break;
                case "course":
                    lectures = Task.Run(() => Connector.connections[0].GetLecturesByCourse(id)).Result;
                    Initialize();
                    break;
                default:
                    ParentChanged -= this.LecturesPanel_ParentChanged;
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
            lecturesdatas.Clear();
            panel1.SuspendLayout();
           await Task.Run(() =>
            {
                if (lectures.Count >= 7)
                {
                    for (int i = 0; i < lectures.Count; i++)
                    {
                        LecturesDataPanel panel = new LecturesDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = lectures[i].Name;
                        panel.pagecountlb.Text += lectures[i].PageCount.ToString();
                        panel.datelb.Text += lectures[i].Date;
                        panel.Width = 764;
                        lecturesdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < lectures.Count; i++)
                    {
                        var panel = new LecturesDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = lectures[i].Name;
                        panel.pagecountlb.Text += lectures[i].PageCount.ToString();
                        panel.datelb.Text += lectures[i].Date;
                        panel.Width = 781;
                        lecturesdatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(lecturesdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Addcinstructorbtn_Click(object sender, EventArgs e)
        {
            newlectures = new AddNewLectures(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newlectures.Size = this.Size;
            this.Controls.Add(newlectures);
            newlectures.BringToFront();
        }
        public void SaveLectures(Lecture lecture)
        {
            lectures.Add(lecture);
            Initialize();
        }
        private void Searchbox_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") searchbox.Text = "";
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
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") return;
            else
            {
                SearchInitialize(searchbox.Text.TrimStart().TrimEnd());
                searchlectures.Clear();
            }
        }
        async void  SearchInitialize(string Name)
        {
            searched = true;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            searchlectures = Task.Run(() => Connector.connections[0].SearchLectures(Name)).Result;
            panel1.Controls.Clear();
            lecturesdatas.Clear();
           await Task.Run(() =>
            {
                panel1.SuspendLayout();
                if (searchlectures.Count >= 7)
                {
                    for (int i = 0; i < searchlectures.Count; i++)
                    {
                        LecturesDataPanel panel = new LecturesDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchlectures[i].Name;
                        panel.pagecountlb.Text += searchlectures[i].PageCount.ToString();
                        panel.datelb.Text += searchlectures[i].Date;
                        panel.Width = 764;
                        lecturesdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < searchlectures.Count; i++)
                    {
                        var panel = new LecturesDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchlectures[i].Name;
                        panel.pagecountlb.Text += searchlectures[i].PageCount.ToString();
                        panel.datelb.Text += searchlectures[i].Date;
                        panel.Width = 781;
                        lecturesdatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(lecturesdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        new public void Update()
        {
            if (_id !=0)
            {
                switch (_who)
                {
                    case "instructor":
                        lectures = Task.Run(() => Connector.connections[0].GetLecturesByInstructor(_id)).Result;
                        Initialize();
                        break;
                    case "material":
                        lectures = Task.Run(() => Connector.connections[0].GetLecturesByMaterial(_id)).Result;
                        Initialize();
                        break;
                    case "course":
                        lectures = Task.Run(() => Connector.connections[0].GetLecturesByCourse(_id)).Result;
                        Initialize();
                        break;
                    default:
                        ParentChanged -= this.LecturesPanel_ParentChanged;
                        this.Dispose(true);
                        break;
                }
            }
            else
            {
                lectures = Task.Run(() => Connector.connections[0].GetLectures()).Result;
                Initialize();
            }
        }
        public void EditLecture(LecturesDataPanel caller)
        {
            var calling = new EditLectures(Connector.connections[0].GetLecture(lectures[panel1.Controls.IndexOf(caller)].Id), this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            calling.Size = this.Size;
            this.Controls.Add(calling);
            calling.BringToFront();
        }
        private void close_Click(object sender, EventArgs e)
        {
            update.Update();
            ParentChanged -= this.LecturesPanel_ParentChanged;
            this.Dispose(true);
        }
        public void Open(object caller, string who)
        {
            Lecture lecture = Connector.connections[0].GetLecture(lectures[panel1.Controls.IndexOf((LecturesDataPanel)caller)].Id);
            if (File.Exists(lecture.Location))
            {
                System.Diagnostics.Process.Start(@lecture.Location);
            }
            else
            {
                MessageBox.Show("File Doesn't Exists\n" +
                    @lecture.Location, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void LecturesPanel_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != Size)
            {
                this.Size = Parent.Size;
            }
        }
        public void _update()
        {
            lectures = Task.Run(() => Connector.connections[0].GetLectures()).Result;
            Initialize();
        }
        private void searchbox_Validated(object sender, EventArgs e)
        {
            if(searchbox.Text == "") searchbox.Text = "Search Here!";
        }
        private void Lecturespl_Click(object sender, EventArgs e)
        {
            lecturespl.Focus();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
