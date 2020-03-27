using Library.Models;
using Library.UserControls.Books;
using Library.UserControls.Instructors;
using Library.UserControls.Lectures;
using Library.UserControls.Materials;
using Library.UserControls.Sections;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library.UserControls.Courses
{
    public partial class CoursePanel : UserControl,IExitAddNewCourse,IEditCourse,IUpdate
    {
        IUpdate update;
        int _id;
        string _who;
        bool searched;
        List<Course> searchcourses;
        List<Course> courses;
        AddNewCourse newcourse;
        List<CourseDataPanel> coursesdatas;
        public CoursePanel()
        {
            InitializeComponent();
            coursesdatas = new List<CourseDataPanel>();
            newcourse = new AddNewCourse(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            courses = Task.Run(() => Connector.connections[0].GetCourses()).Result;
            Initialize();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        public CoursePanel(int id, string who,IUpdate update)
        {
            InitializeComponent();
            coursesdatas = new List<CourseDataPanel>();
            this.update = update;
            _id = id;
            _who = who;
            searchbox.Enabled = false;
            searchbtn.Enabled = false;
            this.addcoursebtn.Click += new System.EventHandler(this.close_Click);
            this.addcoursebtn.Text = "Close";
            switch (who)
            {
                case "instructor":
                    courses = Task.Run(() => Connector.connections[0].GetCourseByInstructor(id)).Result;
                    Initialize();
                    break;
                case "material":
                    courses = Task.Run(() => Connector.connections[0].GetCoursesByMaterial(id)).Result;
                    Initialize();
                    break;
                default:
                    ParentChanged -= CoursePanel_ParentChanged;
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
            coursesdatas.Clear();
            panel1.SuspendLayout();
            await Task.Run(() =>
            {
                if (courses.Count>=7)
            {
                for (int i = 0; i < courses.Count; i++)
                {
                    var panel = new CourseDataPanel(this);
                    panel.Dock = DockStyle.Top;
                    panel.coursenamelb.Text = courses[i].Name;
                    panel.instrectornamelb.Text = courses[i].Instructor.FullName;
                    panel.startlb.Text += courses[i].time.ToString() + " " + courses[i].Day.ToString();
                    panel.periodlb.Text += courses[i].period.ToString();
                    panel.lecnolb.Text += courses[i].Material.NumberOfLectures.ToString();
                    panel.secnolb.Text += courses[i].Material.NumberOfSections.ToString();
                    panel.booksnolb.Text += courses[i].Material.NumberOfBooks.ToString();
                    panel.rowdatabarpl.Width = 764;
                    panel.Width = 764;
                    coursesdatas.Add(panel);
                }
            }
            else
            {
                for (int i = 0; i < courses.Count; i++)
                {
                    var panel = new CourseDataPanel(this);
                    panel.Dock = DockStyle.Top;
                    panel.coursenamelb.Text = courses[i].Name;
                    panel.instrectornamelb.Text = courses[i].Instructor.FullName;
                    panel.startlb.Text += courses[i].time.ToString() +" "+ courses[i].Day.ToString();
                    panel.periodlb.Text += courses[i].period.ToString();
                    panel.lecnolb.Text += courses[i].Material.NumberOfLectures.ToString();
                    panel.secnolb.Text += courses[i].Material.NumberOfSections.ToString();
                    panel.booksnolb.Text += courses[i].Material.NumberOfBooks.ToString();
                    panel.Width = 781;
                    coursesdatas.Add(panel);
                }
            }
            });
            panel1.Controls.AddRange(coursesdatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Addcoursebtn_Click(object sender, EventArgs e)
        {
            newcourse = new AddNewCourse(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newcourse.Size = this.Size;
            this.Controls.Add(newcourse);
            newcourse.BringToFront();
        }
        public void ExitAddNewCourse(Course course)
        {
            courses.Add(course);
            Initialize();
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") return;
            else
            {
                SearchInitialize(searchbox.Text.TrimStart().TrimEnd());
                searchcourses.Clear();
            }
        }
       async void SearchInitialize(string Name)
        {
            searched = true;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            searchcourses = Task.Run(() => Connector.connections[0].SearchCourses(Name)).Result;
            panel1.Controls.Clear();
            coursesdatas.Clear();
            panel1.SuspendLayout();
           await Task.Run(() =>
            {
                if (searchcourses.Count > 7)
                {
                    for (int i = 0; i < searchcourses.Count; i++)
                    {
                        var panel = new CourseDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.coursenamelb.Text = searchcourses[i].Name;
                        panel.instrectornamelb.Text = searchcourses[i].Instructor.FullName;
                        panel.startlb.Text += searchcourses[i].time.ToString() + " " + searchcourses[i].Day.ToString();
                        panel.periodlb.Text += searchcourses[i].period.ToString();
                        panel.lecnolb.Text += searchcourses[i].Material.NumberOfLectures.ToString();
                        panel.secnolb.Text += searchcourses[i].Material.NumberOfSections.ToString();
                        panel.booksnolb.Text += searchcourses[i].Material.NumberOfBooks.ToString();
                        panel.rowdatabarpl.Width = 764;
                        panel.Width = 764;
                        coursesdatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < searchcourses.Count; i++)
                    {
                        var panel = new CourseDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.coursenamelb.Text = searchcourses[i].Name;
                        panel.instrectornamelb.Text = searchcourses[i].Instructor.FullName;
                        panel.startlb.Text += searchcourses[i].time.ToString() + " " + searchcourses[i].Day.ToString();
                        panel.periodlb.Text += searchcourses[i].period.ToString();
                        panel.lecnolb.Text += searchcourses[i].Material.NumberOfLectures.ToString();
                        panel.secnolb.Text += searchcourses[i].Material.NumberOfSections.ToString();
                        panel.booksnolb.Text += searchcourses[i].Material.NumberOfBooks.ToString();
                        panel.Width = 781;
                        coursesdatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(coursesdatas.ToArray());
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
        new public void Update()
        {
            if (_id != 0)
            {
                switch (_who)
                {
                    case "instructor":
                        courses = Task.Run(() => Connector.connections[0].GetCourseByInstructor(_id)).Result;
                        Initialize();
                        break;
                    case "material":
                        courses = Connector.connections[0].GetCoursesByMaterial(_id);
                        Initialize();
                        break;
                    default:
                        ParentChanged -= CoursePanel_ParentChanged;
                        this.Dispose(true);
                        break;
                }
            }
            else
            {
                courses = Task.Run(() => Connector.connections[0].GetCourses()).Result;
                Initialize();
            }
        }
        public void EditCourse(CourseDataPanel caller)
        {
            var calling = new EditCourse(Connector.connections[0].GetCourse(courses[panel1.Controls.IndexOf(caller)].ID), this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            calling.Size = this.Size;
            this.Controls.Add(calling);
            calling.BringToFront();
        }
        private void close_Click(object sender, EventArgs e)
        {
            update.Update();
            ParentChanged -= CoursePanel_ParentChanged;
            this.Dispose(true);
        }
        public void Open(object caller, string who)
        {
            switch (who)
            {
                case "lecture":
                    var calling = new LecturesPanel(Connector.connections[0].GetCourse(courses[panel1.Controls.IndexOf((CourseDataPanel)caller)].ID).ID, "course", this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling.Size = this.Size;
                    this.Controls.Add(calling);
                    calling.BringToFront();
                    break;
                case "section":
                    var calling1 = new SectionsPanel(Connector.connections[0].GetCourse(courses[panel1.Controls.IndexOf((CourseDataPanel)caller)].ID).ID, "course", this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling1.Size = this.Size;
                    this.Controls.Add(calling1);
                    calling1.BringToFront();
                    break;
                case "book":
                    var calling2 = new BooksPanel(Connector.connections[0].GetCourse(courses[panel1.Controls.IndexOf((CourseDataPanel)caller)].ID).ID, "course", this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling2.Size = this.Size;
                    this.Controls.Add(calling2);
                    calling2.BringToFront();
                    break;
                case "instructor":
                    var calling3 = new InstructorPanel(Connector.connections[0].GetCourse(courses[panel1.Controls.IndexOf((CourseDataPanel)caller)].ID).ID, "course", this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling3.Size = this.Size;
                    this.Controls.Add(calling3);
                    calling3.BringToFront();
                    break;
                case "material":
                    var calling4 = new MaterialPanel(Connector.connections[0].GetCourse(courses[panel1.Controls.IndexOf((CourseDataPanel)caller)].ID).ID, "course", this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling4.Size = this.Size;
                    this.Controls.Add(calling4);
                    calling4.BringToFront();
                    break;
            }
        }
        private void CoursePanel_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != this.Size)
            {
                this.Size = Parent.Size;
                newcourse.Size = this.Size;
            }
        }
        public void _update()
        {
            courses = Task.Run(() => Connector.connections[0].GetCourses()).Result;
            Initialize();
        }
        private void searchbox_Validated(object sender, EventArgs e)
        {
            if(searchbox.Text == "") searchbox.Text = "Search Here!";
        }
        private void coursespl_Click(object sender, EventArgs e)
        {
            coursespl.Focus();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
