namespace Library.UserControls.Materials
{
    partial class MaterialPanel
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
            this.materialspl = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.addnewmaterialbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialspl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialspl
            // 
            this.materialspl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.materialspl.Controls.Add(this.searchbtn);
            this.materialspl.Controls.Add(this.searchbox);
            this.materialspl.Controls.Add(this.addnewmaterialbtn);
            this.materialspl.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialspl.Location = new System.Drawing.Point(0, 0);
            this.materialspl.Margin = new System.Windows.Forms.Padding(0);
            this.materialspl.Name = "materialspl";
            this.materialspl.Size = new System.Drawing.Size(781, 47);
            this.materialspl.TabIndex = 3;
            this.materialspl.Click += new System.EventHandler(this.materialspl_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.searchbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(269, 10);
            this.searchbox.Margin = new System.Windows.Forms.Padding(0);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(373, 26);
            this.searchbox.TabIndex = 2;
            this.searchbox.Text = "Search Here!";
            this.searchbox.Click += new System.EventHandler(this.Searchbox_Click);
            this.searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            this.searchbox.Validated += new System.EventHandler(this.searchbox_Validated);
            // 
            // addnewmaterialbtn
            // 
            this.addnewmaterialbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addnewmaterialbtn.FlatAppearance.BorderSize = 0;
            this.addnewmaterialbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.addnewmaterialbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.addnewmaterialbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnewmaterialbtn.Font = new System.Drawing.Font("Tekton Pro", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewmaterialbtn.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addnewmaterialbtn.Location = new System.Drawing.Point(0, 0);
            this.addnewmaterialbtn.Margin = new System.Windows.Forms.Padding(0);
            this.addnewmaterialbtn.Name = "addnewmaterialbtn";
            this.addnewmaterialbtn.Size = new System.Drawing.Size(260, 47);
            this.addnewmaterialbtn.TabIndex = 1;
            this.addnewmaterialbtn.Text = "Add new Material";
            this.addnewmaterialbtn.UseVisualStyleBackColor = true;
            this.addnewmaterialbtn.Click += new System.EventHandler(this.Addcinstructorbtn_Click);
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
            this.pictureBox1.TabIndex = 6;
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
            this.panel1.TabIndex = 11;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // MaterialPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialspl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MaterialPanel";
            this.Size = new System.Drawing.Size(781, 747);
            this.ParentChanged += new System.EventHandler(this.MaterialPanel_ParentChanged);
            this.materialspl.ResumeLayout(false);
            this.materialspl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        public System.Windows.Forms.Panel materialspl;
        public System.Windows.Forms.TextBox searchbox;
        public System.Windows.Forms.Button addnewmaterialbtn;
        public System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
