namespace Library.UserControls.Instructors
{
    partial class InstructorDataPanel
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
            this.components = new System.ComponentModel.Container();
            this.rowdatabarpl = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lecturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phonelb = new System.Windows.Forms.Label();
            this.emaillb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.rowdatabarpl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowdatabarpl
            // 
            this.rowdatabarpl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rowdatabarpl.ContextMenuStrip = this.contextMenuStrip1;
            this.rowdatabarpl.Controls.Add(this.phonelb);
            this.rowdatabarpl.Controls.Add(this.emaillb);
            this.rowdatabarpl.Controls.Add(this.namelb);
            this.rowdatabarpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowdatabarpl.Location = new System.Drawing.Point(0, 0);
            this.rowdatabarpl.Margin = new System.Windows.Forms.Padding(0);
            this.rowdatabarpl.Name = "rowdatabarpl";
            this.rowdatabarpl.Size = new System.Drawing.Size(781, 100);
            this.rowdatabarpl.TabIndex = 4;
            this.rowdatabarpl.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.rowdatabarpl.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.rowdatabarpl.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturesToolStripMenuItem,
            this.sectionsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.materialsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 136);
            this.contextMenuStrip1.Text = "GO TO";
            // 
            // lecturesToolStripMenuItem
            // 
            this.lecturesToolStripMenuItem.Name = "lecturesToolStripMenuItem";
            this.lecturesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.lecturesToolStripMenuItem.Text = "Lectures";
            this.lecturesToolStripMenuItem.Click += new System.EventHandler(this.LecturesToolStripMenuItem_Click);
            // 
            // sectionsToolStripMenuItem
            // 
            this.sectionsToolStripMenuItem.Name = "sectionsToolStripMenuItem";
            this.sectionsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sectionsToolStripMenuItem.Text = "Sections";
            this.sectionsToolStripMenuItem.Click += new System.EventHandler(this.SectionsToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.BooksToolStripMenuItem_Click);
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.materialsToolStripMenuItem.Text = "Materials";
            this.materialsToolStripMenuItem.Click += new System.EventHandler(this.MaterialsToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.CoursesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Library.Properties.Resources.edit1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            this.editToolStripMenuItem.MouseEnter += new System.EventHandler(this.EditToolStripMenuItem_MouseEnter);
            this.editToolStripMenuItem.MouseLeave += new System.EventHandler(this.EditToolStripMenuItem_MouseLeave);
            // 
            // phonelb
            // 
            this.phonelb.AutoSize = true;
            this.phonelb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.phonelb.Location = new System.Drawing.Point(3, 70);
            this.phonelb.Name = "phonelb";
            this.phonelb.Size = new System.Drawing.Size(224, 24);
            this.phonelb.TabIndex = 1;
            this.phonelb.Text = "Phone:01090712307";
            this.phonelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phonelb.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.phonelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.phonelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // emaillb
            // 
            this.emaillb.AutoSize = true;
            this.emaillb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.emaillb.Location = new System.Drawing.Point(3, 38);
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(287, 24);
            this.emaillb.TabIndex = 1;
            this.emaillb.Text = "Email:Email@Address.Com";
            this.emaillb.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.emaillb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.emaillb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(3, 6);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(270, 24);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "Type:Firstname Lastname";
            this.namelb.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.namelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.namelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // InstructorDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rowdatabarpl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InstructorDataPanel";
            this.Size = new System.Drawing.Size(781, 100);
            this.rowdatabarpl.ResumeLayout(false);
            this.rowdatabarpl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
       
        public System.Windows.Forms.Panel rowdatabarpl;
        public System.Windows.Forms.Label emaillb;
        public System.Windows.Forms.Label namelb;
        public System.Windows.Forms.Label phonelb;

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lecturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
