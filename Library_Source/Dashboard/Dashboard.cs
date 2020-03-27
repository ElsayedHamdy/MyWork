using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.UserControls;
using Library.UserControls.Books;
using Library.UserControls.Courses;
using Library.UserControls.Instructors;
using Library.UserControls.Lectures;
using Library.UserControls.Materials;
using Library.UserControls.Sections;
using Microsoft.Win32;

namespace Library
{
    public partial class Dashboard : Form
    {
        CoursePanel newcoursepanel;
        InstructorPanel newinstructorpanel;
        MaterialPanel newmaterialpanel;
        LecturesPanel newlecturepanel;
        SectionsPanel newsectionpanel;
        BooksPanel newbookpanel;
        About newabout;
        private int width;
        private int height;
        public Dashboard()
        {
            InitializeComponent();
            Microsoft.Win32.SystemEvents.UserPreferenceChanged += new Microsoft.Win32.UserPreferenceChangedEventHandler(PreferenceChangedHandler);
            if (Screen.PrimaryScreen.WorkingArea.Height <= 777)
            {
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
            width = this.Width;
            height = this.Height;
            Initialize();
        }
        private void PreferenceChangedHandler(object sender, UserPreferenceChangedEventArgs e)
        {
            if (Screen.PrimaryScreen.WorkingArea.Height <= 777)
            {
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
            if (Screen.PrimaryScreen.WorkingArea.Height - this.Location.Y+this.Height <0)
            {
                this.Location = new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Height-this.Height, this.Location.X);
            }
            else if (Screen.PrimaryScreen.WorkingArea.Width - this.Location.X + this.Width < 0)
            {
                this.Location = new System.Drawing.Point(this.Location.Y, Screen.PrimaryScreen.WorkingArea.Width - this.Width);
            }
            width = this.Width;
            height = this.Height;
        }
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        const int CS_DropSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                cp.ClassStyle |= CS_DropSHADOW;
                return cp;
            }
        }
        void Initialize()
        {
            newcoursepanel = new CoursePanel() { Size = mainpl.Size , Dock = DockStyle.Fill};
            mainpl.Controls.Add(newcoursepanel);
            newinstructorpanel = new InstructorPanel() { Size = mainpl.Size, Dock = DockStyle.Fill };
            mainpl.Controls.Add(newinstructorpanel);
            newmaterialpanel = new MaterialPanel() { Size = mainpl.Size, Dock = DockStyle.Fill };
            mainpl.Controls.Add(newmaterialpanel);
            newlecturepanel = new LecturesPanel() { Size = mainpl.Size, Dock = DockStyle.Fill };
            mainpl.Controls.Add(newlecturepanel);
            newsectionpanel = new SectionsPanel() { Size = mainpl.Size, Dock = DockStyle.Fill };
            mainpl.Controls.Add(newsectionpanel);
            newbookpanel = new BooksPanel() { Size = mainpl.Size, Dock = DockStyle.Fill };
            mainpl.Controls.Add(newbookpanel);
            newabout = new About() { Size = mainpl.Size, Dock = DockStyle.Fill };
            mainpl.Controls.Add(newabout);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            button1_clicked = !button1_clicked;
            menuetm.Start();
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (button1_clicked)
            {
                menuebarpl.Enabled = false;
                if (this.Location.X < 0)
                {
                    this.Location = new System.Drawing.Point(0, this.Location.Y);
                }
                if (this.Size.Width + 15 <= 153+width)
                {
                    this.Size = new System.Drawing.Size(this.Width + 15, this.Height);
                    if (this.Right > Screen.PrimaryScreen.Bounds.Width)
                    {
                        this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width-(this.width+153)), this.Location.Y);
                    }
                }
                else
                {
                    menuebarpl.Enabled = true;
                    this.Size = new System.Drawing.Size(width+153, this.Height);
                    menuetm.Stop();
                }
            }
            else
            {
                menuebarpl.Enabled = false;
                if (this.Location.X < 0)
                {
                    this.Location = new System.Drawing.Point(0, this.Location.Y);
                }
                if (this.Size.Width - 15 >= width)
                {
                    this.Size = new System.Drawing.Size(this.Width - 15, this.Height);
                    if (this.Location.X < 0)
                    {
                        this.Location = new System.Drawing.Point(0, this.Location.Y);
                    }
                }
                else
                {
                    this.Size = new System.Drawing.Size(width, this.Height);
                    if (this.Location.X < 0)
                    {
                        this.Location = new System.Drawing.Point(0, this.Location.Y);
                    }
                    menuetm.Stop();
                }
            }
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = e.Location;
            }
            else
            {
                return;
            }
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                this.Left =  this.Left + e.X - point.X;
                this.Top  =  this.Top  + e.Y - point.Y;
                }
            else
            {
                return;
            }
        }
        private void Coursesbtn_Click(object sender, MouseEventArgs e)
        {
            newcoursepanel._update();
            newcoursepanel.BringToFront();
        }
        private void Instructorbtn_Click(object sender, EventArgs e)
        {
            newinstructorpanel._update();
            newinstructorpanel.BringToFront();
        }
        private void Materialbtn_Click(object sender, EventArgs e)
        {
            newmaterialpanel._update();
            newmaterialpanel.BringToFront();
        }
        private void Booksbtn_Click(object sender, EventArgs e)
        {
            newbookpanel._update();
            newbookpanel.BringToFront();
        }
        private void Lecturesbtn_Click(object sender, EventArgs e)
        {
            newlecturepanel._update();
            newlecturepanel.BringToFront();
        }
        private void Sectionsbtn_Click(object sender, EventArgs e)
        {
            newsectionpanel._update();
            newsectionpanel.BringToFront();
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            newabout.BringToFront();
        }
        private async  void wipebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("you are going to wipe your database\nwhich leads to complete data loss\nso make sure to backup.","Warning!!!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Enabled = false;
                statuslb.Text = "Wiping DataBase Please Wait.";
                this.Text = "Working...";
                await Task.Run(() => Connector.connections[0].Wipe());
                this.Text = "Working Done.";
                statuslb.Text = "Wiping DataBase Done.";
                if (MessageBox.Show("You have Successfully Wiped out your DataBase.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { Library.Properties.Settings.Default.restarting = true; Library.Properties.Settings.Default.Save(); Application.Restart(); }
                else { Library.Properties.Settings.Default.restarting = true; Library.Properties.Settings.Default.Save(); Application.Restart(); }
            }
        }
        private async void backupbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you are going to backup your database.", "Backup DataBase", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Enabled = false;
                statuslb.Text = "Creating a Backup Please Wait.";
                this.Text = "Working...";
                await Task.Run(() => Connector.connections[0].Backup());
                this.Text = "Working Done.";
                statuslb.Text = "Creating a Backup Done.";
                if(MessageBox.Show("You have Successfully Created a Backup for your DataBase.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { Library.Properties.Settings.Default.restarting = true; Library.Properties.Settings.Default.Save(); Application.Restart(); }
                else { Library.Properties.Settings.Default.restarting = true; Library.Properties.Settings.Default.Save(); Application.Restart(); }
            }
        }
        private async void restorebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you are going to restore your database.", "Restore DataBase", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.Enabled = false;
                    statuslb.Text = "Restoring DataBase Please Wait.";
                    this.Text = "Working...";
                    await Task.Run(() => Connector.connections[0].Restore(ofd.FileName));
                    this.Text = "Working Done.";
                    statuslb.Text = "Restoring DataBase Done.";
                    if (MessageBox.Show("You have Successfully Restored your DataBase.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { Library.Properties.Settings.Default.restarting = true; Library.Properties.Settings.Default.Save(); Application.Restart(); }
                    else { Library.Properties.Settings.Default.restarting = true; Library.Properties.Settings.Default.Save(); Application.Restart(); }
                }
            }
        }
        private void headbarpl_Click(object sender, EventArgs e)
        {
            headbarpl.Focus();
        }
        private void mainpl_Click(object sender, EventArgs e)
        {
            mainpl.Focus();
        }
        private void menuebarpl_Click(object sender, EventArgs e)
        {
            menuebarpl.Focus();
        }
        private void staticbarpl_Click(object sender, EventArgs e)
        {
            staticbarpl.Focus();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}
