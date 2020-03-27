namespace Library.UserControls.Books
{
    partial class BooksPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksPanel));
            this.bookspl = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.addcinstructorbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookspl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookspl
            // 
            this.bookspl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bookspl.Controls.Add(this.searchbtn);
            this.bookspl.Controls.Add(this.searchbox);
            this.bookspl.Controls.Add(this.addcinstructorbtn);
            this.bookspl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookspl.Location = new System.Drawing.Point(0, 0);
            this.bookspl.Margin = new System.Windows.Forms.Padding(0);
            this.bookspl.Name = "bookspl";
            this.bookspl.Size = new System.Drawing.Size(781, 47);
            this.bookspl.TabIndex = 5;
            this.bookspl.Click += new System.EventHandler(this.Bookspl_Click);
            // 
            // searchbtn
            // 
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
            // searchbox
            // 
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(232, 10);
            this.searchbox.Margin = new System.Windows.Forms.Padding(0);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(410, 26);
            this.searchbox.TabIndex = 4;
            this.searchbox.Text = "Search Here!";
            this.searchbox.Click += new System.EventHandler(this.Searchbox_Click);
            this.searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            this.searchbox.Validated += new System.EventHandler(this.searchbox_Validated);
            // 
            // addcinstructorbtn
            // 
            this.addcinstructorbtn.FlatAppearance.BorderSize = 0;
            this.addcinstructorbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.addcinstructorbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.addcinstructorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcinstructorbtn.Font = new System.Drawing.Font("Tekton Pro", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcinstructorbtn.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addcinstructorbtn.Location = new System.Drawing.Point(0, 0);
            this.addcinstructorbtn.Margin = new System.Windows.Forms.Padding(0);
            this.addcinstructorbtn.Name = "addcinstructorbtn";
            this.addcinstructorbtn.Size = new System.Drawing.Size(221, 47);
            this.addcinstructorbtn.TabIndex = 1;
            this.addcinstructorbtn.Text = "Add new Book";
            this.addcinstructorbtn.UseVisualStyleBackColor = true;
            this.addcinstructorbtn.Click += new System.EventHandler(this.Addcinstructorbtn_Click);
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
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 327);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BooksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookspl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BooksPanel";
            this.Size = new System.Drawing.Size(781, 747);
            this.ParentChanged += new System.EventHandler(this.BooksPanel_ParentChanged);
            this.bookspl.ResumeLayout(false);
            this.bookspl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        public System.Windows.Forms.Panel bookspl;
        public System.Windows.Forms.Button searchbtn;
        public System.Windows.Forms.Button addcinstructorbtn;
        public System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
