namespace Library.UserControls.Lectures
{
    partial class AddNewLectures
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
            this.donebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errormaterialnamelb = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.materiallb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructordetailslb
            // 
            this.instructordetailslb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructordetailslb.AutoSize = true;
            this.instructordetailslb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.instructordetailslb.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructordetailslb.ForeColor = System.Drawing.Color.SkyBlue;
            this.instructordetailslb.Location = new System.Drawing.Point(207, 9);
            this.instructordetailslb.Name = "instructordetailslb";
            this.instructordetailslb.Size = new System.Drawing.Size(367, 33);
            this.instructordetailslb.TabIndex = 0;
            this.instructordetailslb.Text = "Enter New Lecture Details";
            this.instructordetailslb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelb.ForeColor = System.Drawing.Color.DarkGreen;
            this.namelb.Location = new System.Drawing.Point(32, 116);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(66, 23);
            this.namelb.TabIndex = 1;
            this.namelb.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 116);
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
            this.pagecountlb.Location = new System.Drawing.Point(32, 165);
            this.pagecountlb.Name = "pagecountlb";
            this.pagecountlb.Size = new System.Drawing.Size(116, 23);
            this.pagecountlb.TabIndex = 1;
            this.pagecountlb.Text = "Page Count:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(183, 165);
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
            this.locationlb.Location = new System.Drawing.Point(32, 214);
            this.locationlb.Name = "locationlb";
            this.locationlb.Size = new System.Drawing.Size(89, 23);
            this.locationlb.TabIndex = 1;
            this.locationlb.Text = "Location:";
            // 
            // donebtn
            // 
            this.donebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.donebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.donebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebtn.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.ForeColor = System.Drawing.Color.Maroon;
            this.donebtn.Location = new System.Drawing.Point(648, 267);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(112, 46);
            this.donebtn.TabIndex = 9;
            this.donebtn.Text = "Done!";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.Donebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(518, 167);
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
            this.label6.Location = new System.Drawing.Point(518, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Blank Name!";
            this.label6.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(134, 212);
            this.textBox5.MaxLength = 1000;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(471, 27);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(634, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Maroon;
            this.cancel.Location = new System.Drawing.Point(36, 267);
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
            this.errormaterialnamelb.Location = new System.Drawing.Point(518, 68);
            this.errormaterialnamelb.Name = "errormaterialnamelb";
            this.errormaterialnamelb.Size = new System.Drawing.Size(153, 24);
            this.errormaterialnamelb.TabIndex = 16;
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
            this.comboBox3.Location = new System.Drawing.Point(183, 67);
            this.comboBox3.MaxDropDownItems = 25;
            this.comboBox3.MaxLength = 25;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(329, 27);
            this.comboBox3.Sorted = true;
            this.comboBox3.TabIndex = 14;
            // 
            // materiallb
            // 
            this.materiallb.AutoSize = true;
            this.materiallb.Font = new System.Drawing.Font("3ds", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiallb.ForeColor = System.Drawing.Color.DarkGreen;
            this.materiallb.Location = new System.Drawing.Point(32, 67);
            this.materiallb.Name = "materiallb";
            this.materiallb.Size = new System.Drawing.Size(145, 23);
            this.materiallb.TabIndex = 13;
            this.materiallb.Text = "Material Name:";
            // 
            // AddNewLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errormaterialnamelb);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.materiallb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.locationlb);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pagecountlb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.instructordetailslb);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddNewLectures";
            this.Size = new System.Drawing.Size(781, 747);
            this.ParentChanged += new System.EventHandler(this.AddNewLectures_ParentChanged);
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
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label errormaterialnamelb;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label materiallb;
    }
}
