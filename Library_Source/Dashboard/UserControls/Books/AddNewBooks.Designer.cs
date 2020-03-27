namespace Library.UserControls.Books
{
    partial class AddNewBooks
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
            this.instructordetailslb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pagecountlb = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.locationlb = new System.Windows.Forms.Label();
            this.publisherlb = new System.Windows.Forms.Label();
            this.chaptercountlb = new System.Windows.Forms.Label();
            this.donebtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.authorslist = new System.Windows.Forms.ListBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cancel = new System.Windows.Forms.Button();
            this.errormaterialnamelb = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.materiallb = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // instructordetailslb
            // 
            this.instructordetailslb.AutoSize = true;
            this.instructordetailslb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.instructordetailslb.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructordetailslb.ForeColor = System.Drawing.Color.SkyBlue;
            this.instructordetailslb.Location = new System.Drawing.Point(223, 9);
            this.instructordetailslb.Name = "instructordetailslb";
            this.instructordetailslb.Size = new System.Drawing.Size(335, 33);
            this.instructordetailslb.TabIndex = 0;
            this.instructordetailslb.Text = "Enter New Book Details";
            this.instructordetailslb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.ForeColor = System.Drawing.Color.DarkGreen;
            this.namelb.Location = new System.Drawing.Point(18, 118);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(66, 23);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(169, 116);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pagecountlb
            // 
            this.pagecountlb.AutoSize = true;
            this.pagecountlb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagecountlb.ForeColor = System.Drawing.Color.DarkGreen;
            this.pagecountlb.Location = new System.Drawing.Point(18, 253);
            this.pagecountlb.Name = "pagecountlb";
            this.pagecountlb.Size = new System.Drawing.Size(116, 23);
            this.pagecountlb.TabIndex = 1;
            this.pagecountlb.Text = "Page Count:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(169, 248);
            this.textBox4.MaxLength = 5;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(329, 27);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // locationlb
            // 
            this.locationlb.AutoSize = true;
            this.locationlb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationlb.ForeColor = System.Drawing.Color.DarkGreen;
            this.locationlb.Location = new System.Drawing.Point(18, 290);
            this.locationlb.Name = "locationlb";
            this.locationlb.Size = new System.Drawing.Size(89, 23);
            this.locationlb.TabIndex = 1;
            this.locationlb.Text = "Location:";
            // 
            // publisherlb
            // 
            this.publisherlb.AutoSize = true;
            this.publisherlb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherlb.ForeColor = System.Drawing.Color.DarkGreen;
            this.publisherlb.Location = new System.Drawing.Point(18, 163);
            this.publisherlb.Name = "publisherlb";
            this.publisherlb.Size = new System.Drawing.Size(96, 23);
            this.publisherlb.TabIndex = 1;
            this.publisherlb.Text = "Publisher:";
            // 
            // chaptercountlb
            // 
            this.chaptercountlb.AutoSize = true;
            this.chaptercountlb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaptercountlb.ForeColor = System.Drawing.Color.DarkGreen;
            this.chaptercountlb.Location = new System.Drawing.Point(18, 208);
            this.chaptercountlb.Name = "chaptercountlb";
            this.chaptercountlb.Size = new System.Drawing.Size(141, 23);
            this.chaptercountlb.TabIndex = 1;
            this.chaptercountlb.Text = "Chapter Count:";
            // 
            // donebtn
            // 
            this.donebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.donebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.donebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.donebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebtn.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.ForeColor = System.Drawing.Color.Maroon;
            this.donebtn.Location = new System.Drawing.Point(647, 524);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(112, 46);
            this.donebtn.TabIndex = 9;
            this.donebtn.Text = "Done!";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.Donebtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(169, 160);
            this.textBox2.MaxLength = 25;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(329, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(500, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type A Valid Number!";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(500, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type a Valid Number!";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(500, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Blank Name!";
            this.label6.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(169, 204);
            this.textBox3.MaxLength = 3;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(329, 27);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(156, 286);
            this.textBox5.MaxLength = 1000;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(471, 27);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(18, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(156, 323);
            this.textBox6.MaxLength = 25;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(329, 27);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.Red;
            this.linkLabel6.Location = new System.Drawing.Point(491, 414);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(153, 23);
            this.linkLabel6.TabIndex = 15;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Clear Selection";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel6_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(491, 382);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 23);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Remove Selection";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // authorslist
            // 
            this.authorslist.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorslist.FormattingEnabled = true;
            this.authorslist.ItemHeight = 16;
            this.authorslist.Location = new System.Drawing.Point(156, 360);
            this.authorslist.Name = "authorslist";
            this.authorslist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.authorslist.Size = new System.Drawing.Size(329, 132);
            this.authorslist.TabIndex = 13;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(491, 327);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 23);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Location = new System.Drawing.Point(633, 290);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(81, 23);
            this.linkLabel3.TabIndex = 14;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Browse";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
            // 
            // cancel
            // 
            this.cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Maroon;
            this.cancel.Location = new System.Drawing.Point(22, 524);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(125, 46);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // errormaterialnamelb
            // 
            this.errormaterialnamelb.AutoSize = true;
            this.errormaterialnamelb.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormaterialnamelb.ForeColor = System.Drawing.Color.Maroon;
            this.errormaterialnamelb.Location = new System.Drawing.Point(500, 71);
            this.errormaterialnamelb.Name = "errormaterialnamelb";
            this.errormaterialnamelb.Size = new System.Drawing.Size(153, 24);
            this.errormaterialnamelb.TabIndex = 19;
            this.errormaterialnamelb.Text = "Choose Name!";
            this.errormaterialnamelb.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "DR",
            "ENG",
            "PROF"});
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "DR:Elsayed Hamdy",
            "DR:Elsayed Hamdy",
            "DR:Elsayed Hamdy",
            "DR:Elsayed Hamdy",
            "ENG:Elsayed Hamdy",
            "ENG:Elsayed Hamdy",
            "ENG:Elsayed Hamdy",
            "ENG:Elsayed Hamdy",
            "PROF:Elsayed Hamdy",
            "PROF:Elsayed Hamdy",
            "PROF:Elsayed Hamdy",
            "PROF:Elsayed Hamdy"});
            this.comboBox3.Location = new System.Drawing.Point(169, 72);
            this.comboBox3.MaxDropDownItems = 25;
            this.comboBox3.MaxLength = 25;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(329, 27);
            this.comboBox3.Sorted = true;
            this.comboBox3.TabIndex = 18;
            // 
            // materiallb
            // 
            this.materiallb.AutoSize = true;
            this.materiallb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiallb.ForeColor = System.Drawing.Color.DarkGreen;
            this.materiallb.Location = new System.Drawing.Point(18, 73);
            this.materiallb.Name = "materiallb";
            this.materiallb.Size = new System.Drawing.Size(145, 23);
            this.materiallb.TabIndex = 17;
            this.materiallb.Text = "Material Name:";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.Red;
            this.linkLabel4.Location = new System.Drawing.Point(491, 446);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(118, 23);
            this.linkLabel4.TabIndex = 20;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Remove All";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // AddNewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.errormaterialnamelb);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.materiallb);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.authorslist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationlb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pagecountlb);
            this.Controls.Add(this.chaptercountlb);
            this.Controls.Add(this.publisherlb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.instructordetailslb);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddNewBooks";
            this.Size = new System.Drawing.Size(781, 747);
            this.ParentChanged += new System.EventHandler(this.AddNewBooks_ParentChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label instructordetailslb;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pagecountlb;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label locationlb;
        private System.Windows.Forms.Label publisherlb;
        private System.Windows.Forms.Label chaptercountlb;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox authorslist;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label errormaterialnamelb;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label materiallb;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}
