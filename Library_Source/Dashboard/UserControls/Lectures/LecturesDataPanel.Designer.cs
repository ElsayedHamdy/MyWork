namespace Library.UserControls.Lectures
{
    partial class LecturesDataPanel
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
            this.pagecountlb = new System.Windows.Forms.Label();
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
            this.rowdatabarpl.Controls.Add(this.pagecountlb);
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
            this.datelb.AutoSize = true;
            this.datelb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.datelb.Location = new System.Drawing.Point(3, 70);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(65, 24);
            this.datelb.TabIndex = 1;
            this.datelb.Text = "Date:";
            this.datelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.datelb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.datelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.datelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // pagecountlb
            // 
            this.pagecountlb.AutoSize = true;
            this.pagecountlb.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.pagecountlb.Location = new System.Drawing.Point(3, 38);
            this.pagecountlb.Name = "pagecountlb";
            this.pagecountlb.Size = new System.Drawing.Size(128, 24);
            this.pagecountlb.TabIndex = 1;
            this.pagecountlb.Text = "PageCount:";
            this.pagecountlb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.pagecountlb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.pagecountlb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
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
            this.namelb.Click += new System.EventHandler(this.rowdatabarpl_Click);
            this.namelb.MouseEnter += new System.EventHandler(this.Rowdatabarpl_MouseEnter);
            this.namelb.MouseLeave += new System.EventHandler(this.Rowdatabarpl_MouseLeave);
            // 
            // LecturesDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rowdatabarpl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LecturesDataPanel";
            this.Size = new System.Drawing.Size(781, 100);
            this.rowdatabarpl.ResumeLayout(false);
            this.rowdatabarpl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
       
        public System.Windows.Forms.Panel rowdatabarpl;
        public System.Windows.Forms.Label pagecountlb;
        public System.Windows.Forms.Label namelb;
        public System.Windows.Forms.Label datelb;

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
