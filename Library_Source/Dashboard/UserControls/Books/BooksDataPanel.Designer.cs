namespace Library.UserControls.Books
{
    partial class BooksDataPanel
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datelb = new System.Windows.Forms.Label();
            this.pagenolb = new System.Windows.Forms.Label();
            this.chapternolb = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.rowdatabarpl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowdatabarpl
            // 
            this.rowdatabarpl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rowdatabarpl.ContextMenuStrip = this.contextMenuStrip1;
            this.rowdatabarpl.Controls.Add(this.datelb);
            this.rowdatabarpl.Controls.Add(this.pagenolb);
            this.rowdatabarpl.Controls.Add(this.chapternolb);
            this.rowdatabarpl.Controls.Add(this.author);
            this.rowdatabarpl.Controls.Add(this.publisher);
            this.rowdatabarpl.Controls.Add(this.namelb);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Library.Properties.Resources.edit1;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            this.editToolStripMenuItem.MouseEnter += new System.EventHandler(this.EditToolStripMenuItem_MouseEnter);
            this.editToolStripMenuItem.MouseLeave += new System.EventHandler(this.EditToolStripMenuItem_MouseLeave);
            // 
            // datelb
            // 
            this.datelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.datelb.AutoSize = true;
            this.datelb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.datelb.Location = new System.Drawing.Point(587, 37);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(65, 24);
            this.datelb.TabIndex = 2;
            this.datelb.Text = "Date:";
            this.datelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.datelb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.datelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.datelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // pagenolb
            // 
            this.pagenolb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pagenolb.AutoSize = true;
            this.pagenolb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.pagenolb.Location = new System.Drawing.Point(587, 5);
            this.pagenolb.Name = "pagenolb";
            this.pagenolb.Size = new System.Drawing.Size(92, 24);
            this.pagenolb.TabIndex = 2;
            this.pagenolb.Text = "PageNo:";
            this.pagenolb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagenolb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.pagenolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.pagenolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // chapternolb
            // 
            this.chapternolb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chapternolb.AutoSize = true;
            this.chapternolb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.chapternolb.Location = new System.Drawing.Point(587, 69);
            this.chapternolb.Name = "chapternolb";
            this.chapternolb.Size = new System.Drawing.Size(126, 24);
            this.chapternolb.TabIndex = 3;
            this.chapternolb.Text = "ChapterNo:";
            this.chapternolb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chapternolb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.chapternolb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.chapternolb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.author.Location = new System.Drawing.Point(3, 69);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(81, 24);
            this.author.TabIndex = 1;
            this.author.Text = "Author";
            this.author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.author.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.author.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.author.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.publisher.Location = new System.Drawing.Point(3, 37);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(106, 24);
            this.publisher.TabIndex = 1;
            this.publisher.Text = "Publisher";
            this.publisher.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.publisher.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.publisher.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.Location = new System.Drawing.Point(3, 5);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(68, 24);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "Name";
            this.namelb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.namelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.namelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // BooksDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rowdatabarpl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BooksDataPanel";
            this.Size = new System.Drawing.Size(781, 100);
            this.rowdatabarpl.ResumeLayout(false);
            this.rowdatabarpl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
       
        public System.Windows.Forms.Panel rowdatabarpl;
        public System.Windows.Forms.Label publisher;
        public System.Windows.Forms.Label namelb;
        public System.Windows.Forms.Label author;

        #endregion

        public System.Windows.Forms.Label pagenolb;
        public System.Windows.Forms.Label chapternolb;
        public System.Windows.Forms.Label datelb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
