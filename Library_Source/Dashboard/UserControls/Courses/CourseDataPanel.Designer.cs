namespace Library.UserControls.Courses
{
    partial class CourseDataPanel
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
            this.secnolb = new System.Windows.Forms.Label();
            this.booksnolb = new System.Windows.Forms.Label();
            this.lecnolb = new System.Windows.Forms.Label();
            this.instrectornamelb = new System.Windows.Forms.Label();
            this.periodlb = new System.Windows.Forms.Label();
            this.startlb = new System.Windows.Forms.Label();
            this.coursenamelb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lecturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowdatabarpl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowdatabarpl
            // 
            this.rowdatabarpl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rowdatabarpl.Controls.Add(this.secnolb);
            this.rowdatabarpl.Controls.Add(this.booksnolb);
            this.rowdatabarpl.Controls.Add(this.lecnolb);
            this.rowdatabarpl.Controls.Add(this.instrectornamelb);
            this.rowdatabarpl.Controls.Add(this.periodlb);
            this.rowdatabarpl.Controls.Add(this.startlb);
            this.rowdatabarpl.Controls.Add(this.coursenamelb);
            this.rowdatabarpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowdatabarpl.Location = new System.Drawing.Point(0, 0);
            this.rowdatabarpl.Margin = new System.Windows.Forms.Padding(0);
            this.rowdatabarpl.Name = "rowdatabarpl";
            this.rowdatabarpl.Size = new System.Drawing.Size(781, 100);
            this.rowdatabarpl.TabIndex = 4;
            this.rowdatabarpl.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.rowdatabarpl.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.rowdatabarpl.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // secnolb
            // 
            this.secnolb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.secnolb.AutoSize = true;
            this.secnolb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secnolb.Location = new System.Drawing.Point(483, 72);
            this.secnolb.Margin = new System.Windows.Forms.Padding(0);
            this.secnolb.Name = "secnolb";
            this.secnolb.Size = new System.Drawing.Size(83, 23);
            this.secnolb.TabIndex = 1;
            this.secnolb.Text = "Sec.No:";
            this.secnolb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.secnolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.secnolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // booksnolb
            // 
            this.booksnolb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.booksnolb.AutoSize = true;
            this.booksnolb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksnolb.Location = new System.Drawing.Point(228, 72);
            this.booksnolb.Name = "booksnolb";
            this.booksnolb.Size = new System.Drawing.Size(98, 23);
            this.booksnolb.TabIndex = 1;
            this.booksnolb.Text = "Book.No:";
            this.booksnolb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.booksnolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.booksnolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // lecnolb
            // 
            this.lecnolb.AutoSize = true;
            this.lecnolb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecnolb.Location = new System.Drawing.Point(0, 72);
            this.lecnolb.Margin = new System.Windows.Forms.Padding(0);
            this.lecnolb.Name = "lecnolb";
            this.lecnolb.Size = new System.Drawing.Size(82, 23);
            this.lecnolb.TabIndex = 1;
            this.lecnolb.Text = "Lec.No:";
            this.lecnolb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.lecnolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.lecnolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // instrectornamelb
            // 
            this.instrectornamelb.AutoSize = true;
            this.instrectornamelb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrectornamelb.Location = new System.Drawing.Point(0, 39);
            this.instrectornamelb.Margin = new System.Windows.Forms.Padding(0);
            this.instrectornamelb.Name = "instrectornamelb";
            this.instrectornamelb.Size = new System.Drawing.Size(167, 23);
            this.instrectornamelb.TabIndex = 1;
            this.instrectornamelb.Text = "Instrector Name";
            this.instrectornamelb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.instrectornamelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.instrectornamelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // periodlb
            // 
            this.periodlb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.periodlb.AutoSize = true;
            this.periodlb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodlb.Location = new System.Drawing.Point(483, 39);
            this.periodlb.Name = "periodlb";
            this.periodlb.Size = new System.Drawing.Size(78, 23);
            this.periodlb.TabIndex = 1;
            this.periodlb.Text = "Period:";
            this.periodlb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.periodlb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.periodlb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // startlb
            // 
            this.startlb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startlb.AutoSize = true;
            this.startlb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlb.Location = new System.Drawing.Point(483, 6);
            this.startlb.Name = "startlb";
            this.startlb.Size = new System.Drawing.Size(64, 23);
            this.startlb.TabIndex = 1;
            this.startlb.Text = "Start:";
            this.startlb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.startlb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.startlb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // coursenamelb
            // 
            this.coursenamelb.AutoSize = true;
            this.coursenamelb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursenamelb.Location = new System.Drawing.Point(0, 6);
            this.coursenamelb.Margin = new System.Windows.Forms.Padding(0);
            this.coursenamelb.Name = "coursenamelb";
            this.coursenamelb.Size = new System.Drawing.Size(137, 23);
            this.coursenamelb.TabIndex = 1;
            this.coursenamelb.Text = "Course Name";
            this.coursenamelb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.coursenamelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.coursenamelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturesToolStripMenuItem,
            this.sectionsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.materialsToolStripMenuItem,
            this.instructorsToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 136);
            this.contextMenuStrip1.Text = "GO TO";
            // 
            // lecturesToolStripMenuItem
            // 
            this.lecturesToolStripMenuItem.Name = "lecturesToolStripMenuItem";
            this.lecturesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.lecturesToolStripMenuItem.Text = "Lectures";
            this.lecturesToolStripMenuItem.Click += new System.EventHandler(this.LecturesToolStripMenuItem_Click);
            // 
            // sectionsToolStripMenuItem
            // 
            this.sectionsToolStripMenuItem.Name = "sectionsToolStripMenuItem";
            this.sectionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sectionsToolStripMenuItem.Text = "Sections";
            this.sectionsToolStripMenuItem.Click += new System.EventHandler(this.SectionsToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.BooksToolStripMenuItem_Click);
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.materialsToolStripMenuItem.Text = "Materials";
            this.materialsToolStripMenuItem.Click += new System.EventHandler(this.MaterialsToolStripMenuItem_Click);
            // 
            // instructorsToolStripMenuItem
            // 
            this.instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            this.instructorsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.instructorsToolStripMenuItem.Text = "Instructors";
            this.instructorsToolStripMenuItem.Click += new System.EventHandler(this.InstructorsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Library.Properties.Resources.edit1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            this.editToolStripMenuItem.MouseEnter += new System.EventHandler(this.EditToolStripMenuItem_MouseEnter_1);
            this.editToolStripMenuItem.MouseLeave += new System.EventHandler(this.EditToolStripMenuItem_MouseLeave_1);
            // 
            // CourseDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.rowdatabarpl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CourseDataPanel";
            this.Size = new System.Drawing.Size(781, 100);
            this.rowdatabarpl.ResumeLayout(false);
            this.rowdatabarpl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        public System.Windows.Forms.Panel rowdatabarpl;
        public System.Windows.Forms.Label secnolb;
        public System.Windows.Forms.Label lecnolb;
        public System.Windows.Forms.Label instrectornamelb;
        public System.Windows.Forms.Label periodlb;
        public System.Windows.Forms.Label startlb;
        public System.Windows.Forms.Label coursenamelb;

        #endregion

        public System.Windows.Forms.Label booksnolb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lecturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
