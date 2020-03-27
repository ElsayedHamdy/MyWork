using Library.Models;
using Library.UserControls.Books;
using Library.UserControls.Courses;
using Library.UserControls.Lectures;
using Library.UserControls.Materials;
using Library.UserControls.Sections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library.UserControls.Instructors
{
    public partial class InstructorPanel : UserControl,IExitAddNewInstructor,IEditInstructor,IUpdate
    {
        IUpdate update;
        int _id;
        string _who;
        bool searched;
        AddNewInstructor newinstructor;
        List<Instructor> instructors;
        List<Instructor> searchinstructors;
        List<InstructorDataPanel> instructordatas;
        public InstructorPanel()
        {
            InitializeComponent();
            instructordatas = new List<InstructorDataPanel>();
            newinstructor =  new AddNewInstructor(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            instructors   =  Task.Run(() => Connector.connections[0].GetInstructors()).Result;
            Initialize();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        public InstructorPanel(int id, string who,IUpdate update)
        {
            InitializeComponent();
            instructordatas = new List<InstructorDataPanel>();
            this.update = update;
            _id = id;
            _who = who;
            searchbox.Enabled = false;
            searchbtn.Enabled = false;
            this.addcinstructorbtn.Click += new System.EventHandler(this.close_Click);
            this.addcinstructorbtn.Text = "Close";
            switch (who)
            {
                case "material":
                    instructors = Task.Run(() => Connector.connections[0].GetInstructorsByMaterial(id)).Result;
                    Initialize();
                    break;
                case "course":
                    instructors = Task.Run(() => Connector.connections[0].GetInstructorsByCourse(id)).Result;
                    Initialize();
                    break;
                default:
                    ParentChanged -= this.InstructorPanel_ParentChanged;
                    this.Dispose(true);
                    break;
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            update.Update();
            ParentChanged -= this.InstructorPanel_ParentChanged;
            this.Dispose(true);
        }
        async void Initialize()
        {
            searched = false;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            panel1.Controls.Clear();
            instructordatas.Clear();
            panel1.SuspendLayout();
            await Task.Run(() =>
            {
                if (instructors.Count >= 7)
                {
                    for (int i = 0; i < instructors.Count; i++)
                    {
                        InstructorDataPanel panel = new InstructorDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = instructors[i].FullName;
                        panel.emaillb.Text = instructors[i].Email;
                        panel.phonelb.Text = instructors[i].Phone;
                        panel.Width = 764;
                        instructordatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < instructors.Count; i++)
                    {
                        var panel = new InstructorDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = instructors[i].FullName;
                        panel.emaillb.Text = instructors[i].Email;
                        panel.phonelb.Text = instructors[i].Phone;
                        panel.Width = 781;
                        instructordatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(instructordatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Addcinstructorbtn_Click(object sender, EventArgs e)
        {
            newinstructor = new AddNewInstructor(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newinstructor.Size = this.Size;
            this.Controls.Add(newinstructor);
            newinstructor.BringToFront();
            
        }
        public void ExitAddNewInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
            Initialize();
        }
        private void Searchbox_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ")searchbox.Text = "";
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search Here!" || searchbox.Text == "" || searchbox.Text == " ") return;
            else
            {
                StringBuilder Input = new StringBuilder(searchbox.Text.ToLower());
                StringBuilder FirstName = new StringBuilder();
                StringBuilder LastName = new StringBuilder();
                StringBuilder type = new StringBuilder();
                bool typecomplete = false, firstcomplete = false;
                for (int i = 0; i < Input.Length; i++)
                {
                    if (!typecomplete)
                    {
                        if (char.IsLetter(Input[i]))
                        {
                            type.Append(Input[i]);
                                typecomplete = validtype(type.ToString());
                                if (typecomplete)
                                {
                                    if (Input.Length > i+1)
                                    {
                                        if (Input[i + 1] == '/' || Input[i + 1] == '\\' || Input[i + 1] == '.' || Input[i + 1] == ',' || Input[i + 1] == ':' || Input[i + 1] == ';' || Input[i + 1] == '-' || Input[i + 1] == '_' || Input[i + 1] == '@' || Input[i + 1] == ' ')
                                        {
                                        i++;
                                        }
                                    }
                                    continue;
                                }
                            else if (type.Length == 4)
                            {
                                FirstName.Insert(0, type.ToString());
                                typecomplete = true;
                                type.Clear();
                                continue;
                            }
                        }
                        else if(Input[i] == '/' || Input[i] == '\\' || Input[i] == '.' || Input[i] == ',' || Input[i] == ':' || Input[i] == ';' ||Input[i] == '-' ||Input[i] == '_'||Input[i] == '@'|| Input[i] == ' ')
                        {
                            typecomplete = validtype(type.ToString());
                            if (typecomplete) continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (typecomplete)
                    {
                        if (!firstcomplete)
                        {
                        if (char.IsLetter(Input[i]))
                        {
                            FirstName.Append(Input[i]);
                        }
                        else if (Input[i] == '/' || Input[i] == '\\' || Input[i] == '.' || Input[i] == ',' || Input[i] == ':' || Input[i] == ';' || Input[i] == '-' || Input[i] == '_' || Input[i] == '@' || Input[i] == ' ')
                        {
                            firstcomplete = true;
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                        }
                        else
                        {
                        LastName.Append(Input[i]);
                        }
                    }
                }
                if (FirstName.Length==0)
                {
                    FirstName.Insert(0,type.ToString());
                    type.Clear();
                }
                SearchInitialize(FirstName.ToString(), LastName.ToString(), type.ToString());
                searchinstructors.Clear();
            }
        }
        bool validtype(string type)
        {
            bool valid = true;
            switch (type)
            {
                case "dr":
                    return valid;
                case "eng":
                    return valid;
                case "prof":
                    return valid;
                default:
                    return false;
            }
        }
       async void SearchInitialize(string FirstName,string LastName,string Type)
        {
            searched = true;
            pictureBox1.Visible = true;
            panel1.Enabled = false;
            searchinstructors = Task.Run(() => Connector.connections[0].SearchInstructors(FirstName, LastName, Type)).Result;
            panel1.Controls.Clear();
            instructordatas.Clear();
            panel1.SuspendLayout();
           await Task.Run(() =>
            {
                if (searchinstructors.Count >= 7)
                {
                    for (int i = 0; i < searchinstructors.Count; i++)
                    {
                        InstructorDataPanel panel = new InstructorDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchinstructors[i].FullName;
                        panel.emaillb.Text = searchinstructors[i].Email;
                        panel.phonelb.Text = searchinstructors[i].Phone;
                        panel.Width = 764;
                        instructordatas.Add(panel);
                    }
                }
                else
                {
                    for (int i = 0; i < searchinstructors.Count; i++)
                    {
                        var panel = new InstructorDataPanel(this);
                        panel.Dock = DockStyle.Top;
                        panel.namelb.Text = searchinstructors[i].FullName;
                        panel.emaillb.Text = searchinstructors[i].Email;
                        panel.phonelb.Text = searchinstructors[i].Phone;
                        panel.Width = 781;
                        instructordatas.Add(panel);
                    }
                }
            });
            panel1.Controls.AddRange(instructordatas.ToArray());
            panel1.ResumeLayout();
            pictureBox1.Visible = false;
            panel1.Enabled = true;
        }
        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            if (searchbox.Text == "" && searched == true)
            {
                Initialize();
            }
            else
            {
                return;
            }
        }
        public void EditInstructor(InstructorDataPanel caller)
        {
            var calling = new EditInstructor(Connector.connections[0].GetInstructor(instructors[panel1.Controls.IndexOf(caller)].ID),this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
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
                    case "course":
                        instructors = Task.Run(() => Connector.connections[0].GetInstructorsByCourse(_id)).Result;
                        Initialize();
                        break;
                    case "material":
                        instructors = Task.Run(() => Connector.connections[0].GetInstructorsByMaterial(_id)).Result;
                        Initialize();
                        break;
                    default:
                        ParentChanged -= this.InstructorPanel_ParentChanged;
                        this.Dispose(true);
                        break;
                }
            }
            else
            {
                instructors = Task.Run(() => Connector.connections[0].GetInstructors()).Result;
                Initialize();
            }
        }
        public void Open(object caller,string who)
        {
            switch(who)
            {
                case "lecture":
                    var calling = new LecturesPanel(Connector.connections[0].GetInstructor(instructors[panel1.Controls.IndexOf((InstructorDataPanel)caller)].ID).ID, "instructor",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling.Size = this.Size;
                    this.Controls.Add(calling);
                    calling.BringToFront();
                    break;
                case "section":
                    var calling1 = new SectionsPanel(Connector.connections[0].GetInstructor(instructors[panel1.Controls.IndexOf((InstructorDataPanel)caller)].ID).ID, "instructor",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling1.Size = this.Size;
                    this.Controls.Add(calling1);
                    calling1.BringToFront();
                    break;
                case "book":
                    var calling2 = new BooksPanel(Connector.connections[0].GetInstructor(instructors[panel1.Controls.IndexOf((InstructorDataPanel)caller)].ID).ID, "instructor",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling2.Size = this.Size;
                    this.Controls.Add(calling2);
                    calling2.BringToFront();
                    break;
                case "course":
                    var calling3 = new CoursePanel(Connector.connections[0].GetInstructor(instructors[panel1.Controls.IndexOf((InstructorDataPanel)caller)].ID).ID, "instructor",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling3.Size = this.Size;
                    this.Controls.Add(calling3);
                    calling3.BringToFront();
                    break;
                case "material":
                    var calling4 = new MaterialPanel(Connector.connections[0].GetInstructor(instructors[panel1.Controls.IndexOf((InstructorDataPanel)caller)].ID).ID, "instructor",this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
                    calling4.Size = this.Size;
                    this.Controls.Add(calling4);
                    calling4.BringToFront();
                    break;
            }
        }
        private void InstructorPanel_ParentChanged(object sender, EventArgs e)
        {
            if (Parent.Size != Size)
            {
                this.Size = Parent.Size;
            }
        }
        public void _update()
        {
            instructors = Task.Run(() => Connector.connections[0].GetInstructors()).Result;
            Initialize();
        }
        private void searchbox_Validated(object sender, EventArgs e)
        {
            if(searchbox.Text == "") searchbox.Text = "Search Here!";
        }
        private void instructorpl_Click(object sender, EventArgs e)
        {
            instructorpl.Focus();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
