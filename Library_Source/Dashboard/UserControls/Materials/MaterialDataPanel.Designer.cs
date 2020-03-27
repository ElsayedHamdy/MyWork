namespace Library.UserControls.Materials
{
    partial class MaterialDataPanel
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
            this.pagenolb = new System.Windows.Forms.Label();
            this.lecnolb = new System.Windows.Forms.Label();
            this.secnolb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lecturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowdatabarpl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowdatabarpl
            // 
            this.rowdatabarpl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rowdatabarpl.Controls.Add(this.pagenolb);
            this.rowdatabarpl.Controls.Add(this.lecnolb);
            this.rowdatabarpl.Controls.Add(this.secnolb);
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
            // pagenolb
            // 
            this.pagenolb.AutoSize = true;
            this.pagenolb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.pagenolb.Location = new System.Drawing.Point(3, 74);
            this.pagenolb.Name = "pagenolb";
            this.pagenolb.Size = new System.Drawing.Size(95, 24);
            this.pagenolb.TabIndex = 1;
            this.pagenolb.Text = "BookNo:";
            this.pagenolb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagenolb.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.pagenolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.pagenolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // lecnolb
            // 
            this.lecnolb.AutoSize = true;
            this.lecnolb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.lecnolb.Location = new System.Drawing.Point(3, 50);
            this.lecnolb.Name = "lecnolb";
            this.lecnolb.Size = new System.Drawing.Size(80, 24);
            this.lecnolb.TabIndex = 1;
            this.lecnolb.Text = "LecNo:";
            this.lecnolb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lecnolb.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.lecnolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.lecnolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // secnolb
            // 
            this.secnolb.AutoSize = true;
            this.secnolb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.secnolb.Location = new System.Drawing.Point(3, 26);
            this.secnolb.Name = "secnolb";
            this.secnolb.Size = new System.Drawing.Size(80, 24);
            this.secnolb.TabIndex = 1;
            this.secnolb.Text = "SecNo:";
            this.secnolb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secnolb.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.secnolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.secnolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(3, 2);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(68, 24);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "Name";
            this.namelb.Click += new System.EventHandler(this.Rowdatabarpl_Click);
            this.namelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.namelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturesToolStripMenuItem,
            this.sectionsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.coursesToolStripMenuItem,
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
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.CoursesToolStripMenuItem_Click);
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
            this.editToolStripMenuItem.MouseEnter += new System.EventHandler(this.EditToolStripMenuItem_MouseEnter);
            this.editToolStripMenuItem.MouseLeave += new System.EventHandler(this.EditToolStripMenuItem_MouseLeave);
            // 
            // MaterialDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.rowdatabarpl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MaterialDataPanel";
            this.Size = new System.Drawing.Size(781, 100);
            this.rowdatabarpl.ResumeLayout(false);
            this.rowdatabarpl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        //private void InitializeComponent(Library.Courses courses)
        //{
        //    this.rowdatabarpl = new System.Windows.Forms.Panel();
        //    this.picdata = new System.Windows.Forms.PictureBox();
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.rowdatabarpl.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.picdata)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // rowdatabarpl
        //    // 
        //    this.rowdatabarpl.BackColor = System.Drawing.SystemColors.MenuHighlight;
        //    this.rowdatabarpl.Controls.Add(this.label1);
        //    this.rowdatabarpl.Controls.Add(this.picdata);
        //    this.rowdatabarpl.Location = new System.Drawing.Point(0, 0);
        //    this.rowdatabarpl.Margin = new System.Windows.Forms.Padding(0);
        //    this.rowdatabarpl.Name = "rowdatabarpl";
        //    this.rowdatabarpl.Size = new System.Drawing.Size(764, 100);
        //    this.rowdatabarpl.TabIndex = 4;
        //    // 
        //    // picdata
        //    // 
        //    this.picdata.BackColor = System.Drawing.SystemColors.Info;
        //    this.picdata.Location = new System.Drawing.Point(0, 0);
        //    this.picdata.Margin = new System.Windows.Forms.Padding(0);
        //    this.picdata.Name = "picdata";
        //    this.picdata.Size = new System.Drawing.Size(100, 100);
        //    this.picdata.TabIndex = 0;
        //    this.picdata.TabStop = false;
        //    // 
        //    // label1
        //    // 
        //    this.label1.AutoSize = true;
        //    this.label1.Location = new System.Drawing.Point(113, 25);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(35, 13);
        //    this.label1.TabIndex = 1;
        //    this.label1.Text = "label1";
        //    // 
        //    // RowDataPanel
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.Controls.Add(this.rowdatabarpl);
        //    this.Name = "RowDataPanel";
        //    this.Size = new System.Drawing.Size(764, 100);
        //    this.rowdatabarpl.ResumeLayout(false);
        //    this.rowdatabarpl.PerformLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.picdata)).EndInit();
        //    this.ResumeLayout(false);

        //}
        public System.Windows.Forms.Panel rowdatabarpl;
        public System.Windows.Forms.Label namelb;
        public System.Windows.Forms.Label secnolb;
        public int index=1;

        #endregion

        public System.Windows.Forms.Label pagenolb;
        public System.Windows.Forms.Label lecnolb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lecturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
