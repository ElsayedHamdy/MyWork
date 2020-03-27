//using Dashboard.UserControls;
namespace Library
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        bool button1_clicked;
        System.Drawing.Point point;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.headbarpl = new System.Windows.Forms.Panel();
            this.statuslb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.staticbarpl = new System.Windows.Forms.Panel();
            this.restorebtn = new System.Windows.Forms.Button();
            this.backupbtn = new System.Windows.Forms.Button();
            this.wipebtn = new System.Windows.Forms.Button();
            this.expandbtn = new System.Windows.Forms.Button();
            this.menuebarpl = new System.Windows.Forms.Panel();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.booksbtn = new System.Windows.Forms.Button();
            this.sectionsbtn = new System.Windows.Forms.Button();
            this.lecturesbtn = new System.Windows.Forms.Button();
            this.instructorbtn = new System.Windows.Forms.Button();
            this.materialbtn = new System.Windows.Forms.Button();
            this.coursesbtn = new System.Windows.Forms.Button();
            this.mylibrarybtn = new System.Windows.Forms.Button();
            this.menuetm = new System.Windows.Forms.Timer(this.components);
            this.mainpl = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.headbarpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.staticbarpl.SuspendLayout();
            this.menuebarpl.SuspendLayout();
            this.SuspendLayout();
            // 
            // headbarpl
            // 
            this.headbarpl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headbarpl.Controls.Add(this.statuslb);
            this.headbarpl.Controls.Add(this.label1);
            this.headbarpl.Controls.Add(this.pictureBox1);
            this.headbarpl.Controls.Add(this.button1);
            this.headbarpl.Controls.Add(this.exitbtn);
            this.headbarpl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headbarpl.Location = new System.Drawing.Point(0, 0);
            this.headbarpl.Margin = new System.Windows.Forms.Padding(0);
            this.headbarpl.Name = "headbarpl";
            this.headbarpl.Size = new System.Drawing.Size(817, 30);
            this.headbarpl.TabIndex = 0;
            this.headbarpl.Click += new System.EventHandler(this.headbarpl_Click);
            this.headbarpl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.headbarpl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // statuslb
            // 
            this.statuslb.AutoSize = true;
            this.statuslb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslb.Location = new System.Drawing.Point(328, 9);
            this.statuslb.Name = "statuslb";
            this.statuslb.Size = new System.Drawing.Size(0, 18);
            this.statuslb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(39, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "MY LIBRARY";
            this.toolTip1.SetToolTip(this.label1, "Appilication Name");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Library.Properties.Resources.icons8_engineer_483;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Appilicaton Logo");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(737, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "-";
            this.toolTip1.SetToolTip(this.button1, "Minimize Button\r\nUsed to Minimize Appilication");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitbtn.Location = new System.Drawing.Point(777, 0);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(40, 30);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.TabStop = false;
            this.exitbtn.Text = "X";
            this.toolTip1.SetToolTip(this.exitbtn, "Close Button\r\nUsed to Close the Appilication");
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.Button10_Click);
            // 
            // staticbarpl
            // 
            this.staticbarpl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.staticbarpl.Controls.Add(this.restorebtn);
            this.staticbarpl.Controls.Add(this.backupbtn);
            this.staticbarpl.Controls.Add(this.wipebtn);
            this.staticbarpl.Controls.Add(this.expandbtn);
            this.staticbarpl.Dock = System.Windows.Forms.DockStyle.Left;
            this.staticbarpl.Location = new System.Drawing.Point(0, 30);
            this.staticbarpl.Margin = new System.Windows.Forms.Padding(0);
            this.staticbarpl.Name = "staticbarpl";
            this.staticbarpl.Size = new System.Drawing.Size(36, 747);
            this.staticbarpl.TabIndex = 1;
            this.staticbarpl.TabStop = true;
            this.staticbarpl.Click += new System.EventHandler(this.staticbarpl_Click);
            // 
            // restorebtn
            // 
            this.restorebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.restorebtn.FlatAppearance.BorderSize = 0;
            this.restorebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.restorebtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.restorebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.restorebtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.restorebtn.Location = new System.Drawing.Point(0, 639);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(36, 36);
            this.restorebtn.TabIndex = 3;
            this.restorebtn.TabStop = false;
            this.restorebtn.Text = "R";
            this.toolTip1.SetToolTip(this.restorebtn, "Restore Button\r\nUsed to Restore your DataBase\r\n\r\n");
            this.restorebtn.UseVisualStyleBackColor = true;
            this.restorebtn.Click += new System.EventHandler(this.restorebtn_Click);
            // 
            // backupbtn
            // 
            this.backupbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backupbtn.FlatAppearance.BorderSize = 0;
            this.backupbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.backupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.backupbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.backupbtn.Location = new System.Drawing.Point(0, 675);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(36, 36);
            this.backupbtn.TabIndex = 2;
            this.backupbtn.TabStop = false;
            this.backupbtn.Text = "B";
            this.toolTip1.SetToolTip(this.backupbtn, "Backup Button\r\nUsed to Create a Backup of the DataBase\r\n");
            this.backupbtn.UseVisualStyleBackColor = true;
            this.backupbtn.Click += new System.EventHandler(this.backupbtn_Click);
            // 
            // wipebtn
            // 
            this.wipebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wipebtn.FlatAppearance.BorderSize = 0;
            this.wipebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.wipebtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.wipebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wipebtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.wipebtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.wipebtn.Location = new System.Drawing.Point(0, 711);
            this.wipebtn.Name = "wipebtn";
            this.wipebtn.Size = new System.Drawing.Size(36, 36);
            this.wipebtn.TabIndex = 1;
            this.wipebtn.TabStop = false;
            this.wipebtn.Text = "W";
            this.toolTip1.SetToolTip(this.wipebtn, "Wipe Button\r\nUsed to Wipe out the DataBase");
            this.wipebtn.UseVisualStyleBackColor = true;
            this.wipebtn.Click += new System.EventHandler(this.wipebtn_Click);
            // 
            // expandbtn
            // 
            this.expandbtn.FlatAppearance.BorderSize = 0;
            this.expandbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.expandbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.expandbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandbtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.expandbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.expandbtn.Location = new System.Drawing.Point(0, 0);
            this.expandbtn.Name = "expandbtn";
            this.expandbtn.Size = new System.Drawing.Size(36, 36);
            this.expandbtn.TabIndex = 0;
            this.expandbtn.TabStop = false;
            this.expandbtn.Text = "|||";
            this.expandbtn.UseVisualStyleBackColor = true;
            this.expandbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuebarpl
            // 
            this.menuebarpl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuebarpl.Controls.Add(this.aboutbtn);
            this.menuebarpl.Controls.Add(this.booksbtn);
            this.menuebarpl.Controls.Add(this.sectionsbtn);
            this.menuebarpl.Controls.Add(this.lecturesbtn);
            this.menuebarpl.Controls.Add(this.instructorbtn);
            this.menuebarpl.Controls.Add(this.materialbtn);
            this.menuebarpl.Controls.Add(this.coursesbtn);
            this.menuebarpl.Controls.Add(this.mylibrarybtn);
            this.menuebarpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuebarpl.Location = new System.Drawing.Point(36, 30);
            this.menuebarpl.Margin = new System.Windows.Forms.Padding(0);
            this.menuebarpl.Name = "menuebarpl";
            this.menuebarpl.Size = new System.Drawing.Size(0, 747);
            this.menuebarpl.TabIndex = 2;
            this.menuebarpl.Click += new System.EventHandler(this.menuebarpl_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutbtn.FlatAppearance.BorderSize = 0;
            this.aboutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.aboutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.aboutbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.aboutbtn.Location = new System.Drawing.Point(0, 350);
            this.aboutbtn.Margin = new System.Windows.Forms.Padding(0);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(0, 50);
            this.aboutbtn.TabIndex = 0;
            this.aboutbtn.Text = "About";
            this.toolTip1.SetToolTip(this.aboutbtn, "About Button\r\nShows Information about the Developer");
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.Aboutbtn_Click);
            // 
            // booksbtn
            // 
            this.booksbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksbtn.FlatAppearance.BorderSize = 0;
            this.booksbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.booksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.booksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksbtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.booksbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.booksbtn.Location = new System.Drawing.Point(0, 300);
            this.booksbtn.Margin = new System.Windows.Forms.Padding(0);
            this.booksbtn.Name = "booksbtn";
            this.booksbtn.Size = new System.Drawing.Size(0, 50);
            this.booksbtn.TabIndex = 0;
            this.booksbtn.Text = "Books";
            this.toolTip1.SetToolTip(this.booksbtn, "Books Button\r\nDisplays Current Books Stored in DataBase");
            this.booksbtn.UseVisualStyleBackColor = true;
            this.booksbtn.Click += new System.EventHandler(this.Booksbtn_Click);
            // 
            // sectionsbtn
            // 
            this.sectionsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sectionsbtn.FlatAppearance.BorderSize = 0;
            this.sectionsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.sectionsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sectionsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectionsbtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sectionsbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.sectionsbtn.Location = new System.Drawing.Point(0, 250);
            this.sectionsbtn.Margin = new System.Windows.Forms.Padding(0);
            this.sectionsbtn.Name = "sectionsbtn";
            this.sectionsbtn.Size = new System.Drawing.Size(0, 50);
            this.sectionsbtn.TabIndex = 0;
            this.sectionsbtn.Text = "Sections";
            this.toolTip1.SetToolTip(this.sectionsbtn, "Sections Button\r\nDisplays Current Sections Stored in DataBase\r\n");
            this.sectionsbtn.UseVisualStyleBackColor = true;
            this.sectionsbtn.Click += new System.EventHandler(this.Sectionsbtn_Click);
            // 
            // lecturesbtn
            // 
            this.lecturesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lecturesbtn.FlatAppearance.BorderSize = 0;
            this.lecturesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.lecturesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lecturesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecturesbtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lecturesbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.lecturesbtn.Location = new System.Drawing.Point(0, 200);
            this.lecturesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.lecturesbtn.Name = "lecturesbtn";
            this.lecturesbtn.Size = new System.Drawing.Size(0, 50);
            this.lecturesbtn.TabIndex = 0;
            this.lecturesbtn.Text = "Lectures";
            this.toolTip1.SetToolTip(this.lecturesbtn, "Lectures Button\r\nDisplays Current Lectures Stored in DataBase\r\n");
            this.lecturesbtn.UseVisualStyleBackColor = true;
            this.lecturesbtn.Click += new System.EventHandler(this.Lecturesbtn_Click);
            // 
            // instructorbtn
            // 
            this.instructorbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.instructorbtn.FlatAppearance.BorderSize = 0;
            this.instructorbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.instructorbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.instructorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorbtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.instructorbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.instructorbtn.Location = new System.Drawing.Point(0, 150);
            this.instructorbtn.Margin = new System.Windows.Forms.Padding(0);
            this.instructorbtn.Name = "instructorbtn";
            this.instructorbtn.Size = new System.Drawing.Size(0, 50);
            this.instructorbtn.TabIndex = 0;
            this.instructorbtn.Text = "Instructors";
            this.toolTip1.SetToolTip(this.instructorbtn, "Instructors Button\r\nDisplays Current Instructors Stored in DataBase\r\n");
            this.instructorbtn.UseVisualStyleBackColor = true;
            this.instructorbtn.Click += new System.EventHandler(this.Instructorbtn_Click);
            // 
            // materialbtn
            // 
            this.materialbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialbtn.FlatAppearance.BorderSize = 0;
            this.materialbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.materialbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.materialbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialbtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.materialbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.materialbtn.Location = new System.Drawing.Point(0, 100);
            this.materialbtn.Margin = new System.Windows.Forms.Padding(0);
            this.materialbtn.Name = "materialbtn";
            this.materialbtn.Size = new System.Drawing.Size(0, 50);
            this.materialbtn.TabIndex = 0;
            this.materialbtn.Text = "Materials";
            this.toolTip1.SetToolTip(this.materialbtn, "Materials Button\r\nDisplays Current Materials Stored in DataBase\r\n");
            this.materialbtn.UseVisualStyleBackColor = true;
            this.materialbtn.Click += new System.EventHandler(this.Materialbtn_Click);
            // 
            // coursesbtn
            // 
            this.coursesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.coursesbtn.FlatAppearance.BorderSize = 0;
            this.coursesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.coursesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.coursesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursesbtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.coursesbtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.coursesbtn.Location = new System.Drawing.Point(0, 50);
            this.coursesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.coursesbtn.Name = "coursesbtn";
            this.coursesbtn.Size = new System.Drawing.Size(0, 50);
            this.coursesbtn.TabIndex = 0;
            this.coursesbtn.Text = "Courses";
            this.toolTip1.SetToolTip(this.coursesbtn, "Courses Button\r\nDisplays Current Courses Stored in DataBase\r\n");
            this.coursesbtn.UseVisualStyleBackColor = true;
            this.coursesbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Coursesbtn_Click);
            // 
            // mylibrarybtn
            // 
            this.mylibrarybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mylibrarybtn.FlatAppearance.BorderSize = 0;
            this.mylibrarybtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mylibrarybtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mylibrarybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mylibrarybtn.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mylibrarybtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.mylibrarybtn.Location = new System.Drawing.Point(0, 0);
            this.mylibrarybtn.Margin = new System.Windows.Forms.Padding(0);
            this.mylibrarybtn.Name = "mylibrarybtn";
            this.mylibrarybtn.Size = new System.Drawing.Size(0, 50);
            this.mylibrarybtn.TabIndex = 0;
            this.mylibrarybtn.Text = "My Library";
            this.mylibrarybtn.UseVisualStyleBackColor = true;
            // 
            // menuetm
            // 
            this.menuetm.Interval = 25;
            this.menuetm.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // mainpl
            // 
            this.mainpl.BackColor = System.Drawing.SystemColors.Control;
            this.mainpl.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainpl.Location = new System.Drawing.Point(36, 30);
            this.mainpl.Margin = new System.Windows.Forms.Padding(0);
            this.mainpl.Name = "mainpl";
            this.mainpl.Size = new System.Drawing.Size(781, 747);
            this.mainpl.TabIndex = 3;
            this.mainpl.Click += new System.EventHandler(this.mainpl_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(817, 777);
            this.Controls.Add(this.menuebarpl);
            this.Controls.Add(this.staticbarpl);
            this.Controls.Add(this.mainpl);
            this.Controls.Add(this.headbarpl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.headbarpl.ResumeLayout(false);
            this.headbarpl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.staticbarpl.ResumeLayout(false);
            this.menuebarpl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        
        private System.Windows.Forms.Panel staticbarpl;
        private System.Windows.Forms.Button expandbtn;
        private System.Windows.Forms.Panel menuebarpl;
        private System.Windows.Forms.Panel headbarpl;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button mylibrarybtn;
        private System.Windows.Forms.Button instructorbtn;
        private System.Windows.Forms.Button coursesbtn;
        private System.Windows.Forms.Button materialbtn;
        private System.Windows.Forms.Button lecturesbtn;
        private System.Windows.Forms.Button booksbtn;
        private System.Windows.Forms.Button sectionsbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Timer menuetm;
        public System.Windows.Forms.Panel mainpl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wipebtn;
        private System.Windows.Forms.Button backupbtn;
        private System.Windows.Forms.Button restorebtn;
        private System.Windows.Forms.Label statuslb;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

