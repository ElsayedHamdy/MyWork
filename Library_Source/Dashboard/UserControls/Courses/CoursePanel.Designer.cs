namespace Library.UserControls.Courses
{
    partial class CoursePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coursespl = new System.Windows.Forms.Panel();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.addcoursebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coursespl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // coursespl
            // 
            this.coursespl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.coursespl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.coursespl.Controls.Add(this.searchbox);
            this.coursespl.Controls.Add(this.searchbtn);
            this.coursespl.Controls.Add(this.addcoursebtn);
            this.coursespl.Dock = System.Windows.Forms.DockStyle.Top;
            this.coursespl.Location = new System.Drawing.Point(0, 0);
            this.coursespl.Margin = new System.Windows.Forms.Padding(0);
            this.coursespl.Name = "coursespl";
            this.coursespl.Size = new System.Drawing.Size(781, 47);
            this.coursespl.TabIndex = 3;
            this.coursespl.Click += new System.EventHandler(this.coursespl_Click);
            // 
            // searchbox
            // 
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(254, 10);
            this.searchbox.Margin = new System.Windows.Forms.Padding(0);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(390, 26);
            this.searchbox.TabIndex = 2;
            this.searchbox.Text = "Search Here!";
            this.searchbox.Click += new System.EventHandler(this.Searchbox_Click);
            this.searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            this.searchbox.Validated += new System.EventHandler(this.searchbox_Validated);
            // 
            // searchbtn
            // 
            this.searchbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Tekton Pro", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchbtn.Location = new System.Drawing.Point(653, 0);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(128, 47);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // addcoursebtn
            // 
            this.addcoursebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addcoursebtn.FlatAppearance.BorderSize = 0;
            this.addcoursebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.addcoursebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.addcoursebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcoursebtn.Font = new System.Drawing.Font("Tekton Pro", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcoursebtn.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addcoursebtn.Location = new System.Drawing.Point(0, 0);
            this.addcoursebtn.Margin = new System.Windows.Forms.Padding(0);
            this.addcoursebtn.Name = "addcoursebtn";
            this.addcoursebtn.Size = new System.Drawing.Size(245, 47);
            this.addcoursebtn.TabIndex = 1;
            this.addcoursebtn.Text = "Add new Course";
            this.addcoursebtn.UseVisualStyleBackColor = true;
            this.addcoursebtn.Click += new System.EventHandler(this.Addcoursebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Library.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(310, 327);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 700);
            this.panel1.TabIndex = 10;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // CoursePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.coursespl);
            this.Name = "CoursePanel";
            this.Size = new System.Drawing.Size(781, 747);
            this.ParentChanged += new System.EventHandler(this.CoursePanel_ParentChanged);
            this.coursespl.ResumeLayout(false);
            this.coursespl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel coursespl;
        private System.Windows.Forms.Button addcoursebtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
