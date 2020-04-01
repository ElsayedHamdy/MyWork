﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library.Models;
using Library.UserControls.Instructors;
using Library.UserControls.Materials;
namespace Library.UserControls.Courses
{
    public partial class EditCourse : UserControl,IExitAddNewInstructor,IExitAddNewMaterial
    {
        Course course;
        IUpdate calling;
        AddNewInstructor newinstructor;
        AddNewMaterial newmaterial;
        public EditCourse(Course course,IUpdate caller)
        {
            InitializeComponent();
            newinstructor = new AddNewInstructor(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newmaterial = new AddNewMaterial(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            calling = caller;
            this.course = course;
            wireup();
        }
        private List<Instructor> instructors = Connector.connections[0].GetInstructors();
        private List<Material> materials = Connector.connections[0].GetMaterials();
        void wireup()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = instructors;
            comboBox2.DisplayMember = nameof(Instructor.FullName);
            comboBox2.SelectedIndex = comboBox2.FindStringExact(this.course.Instructor.FullName);
            comboBox3.DataSource = null;
            comboBox3.DataSource = materials;
            comboBox3.DisplayMember = nameof(Material.Name);
            comboBox3.SelectedIndex = comboBox3.FindStringExact(this.course.Material.Name);
            textBox1.Text = course.Name;
            textBox4.Text = course.Price.ToString();
            textBox5.Text = course.Place;
            weekdayslist.SelectedItem = course.Day.ToString();
            timehrdropdown.Value = course.time.Hour;
            timemindropdown.Value = course.time.Minute;
            timesecdropdown.Value = course.time.Second;
            comboBox1.SelectedItem = course.time.TimeFormat.ToString();
            periodhrdropdown.Value = course.period.Hours;
            periodmindropdown.Value = course.period.Minutes;
            periodsecdropdown.Value = course.period.Seconds;
        }
        void wireup_instructor()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = instructors;
            comboBox2.DisplayMember = nameof(Instructor.FullName);
        }
        void wireup_material()
        {
            comboBox3.DataSource = null;
            comboBox3.DataSource = materials;
            comboBox3.DisplayMember = nameof(Material.Name);
        }
        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Instructornewlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newinstructor = new AddNewInstructor(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newinstructor.Size = this.Size;
            this.Controls.Add(newinstructor);
            newinstructor.BringToFront();
        }
        private void Materialnewlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newmaterial = new AddNewMaterial(this) { Anchor = AnchorStyles.Top | AnchorStyles.Bottom };
            newmaterial.Size = this.Size;
            this.Controls.Add(newmaterial);
            newmaterial.BringToFront();
        }
        private void Donebtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                errorinstructornamelb.Visible = false;
                errormaterialnamelb.Visible = false;
                errorpricelb.Visible = false;
                errordaylb.Visible = false;
                errorformatlb.Visible = false;
                errorinstructornamelb.Visible = false;
                errorplacelb.Visible = false;
                Course course = new Course();
                course.Name = textBox1.Text;
                course.Instructor = comboBox2.SelectedItem as Instructor;
                course.Material = comboBox3.SelectedItem as Material;
                course.Place = (textBox5.Text == "") ? "Unkown Place" : textBox5.Text;
                course.Price = int.Parse(textBox4.Text);
                course.period = new Period((int)periodhrdropdown.Value,(int) periodmindropdown.Value,(int) periodsecdropdown.Value);
                course.time = new Time((int)timehrdropdown.Value, (int)timemindropdown.Value, (int)timesecdropdown.Value,Convert.ToTimeFormat(comboBox1.SelectedItem.ToString()));
                course.Day = Convert.ToDays(weekdayslist.SelectedItem.ToString());
                course.ID = this.course.ID;
                foreach (var item in Connector.connections)
                {
                    if (item.CheckCourses(course))
                    {
                        if (MessageBox.Show("You Have Already Add this Course.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK) return;
                        else return;
                    }
                    else
                    {
                        if (!item.CheckInstructors(course.Instructor)) course.Instructor = item.CreateInstructor(course.Instructor);
                        if (!item.CheckMaterials(course.Material))     course.Material = item.CreateMaterials(course.Material);
                        item.UpdateCourse(course);
                    }
                }
                calling.Update();
                ParentChanged -= this.EditCourse_ParentChanged;
                this.Dispose();
            }
        }
        bool validate()
        {
            bool valid = true;
            if (textBox1.Text == null || textBox1.Text == "" || textBox1.Text == " ")
            {
                errorcoursenamelb.Visible = true;
                valid = false;
            }
            else
            {
                errorcoursenamelb.Visible = false;
            }
            if (comboBox2.SelectedItem == null)
            {
                errorinstructornamelb.Visible = true;
                valid = false;
            }
            else
            {
                errorinstructornamelb.Visible = false;
            }
            if (comboBox3.SelectedItem == null)
            {
                errormaterialnamelb.Visible = true;
                valid = false;
            }
            else
            {
                errormaterialnamelb.Visible = false;
            }
            if (textBox4.Text == null || textBox4.Text == "" || textBox4.Text == " ")
            {
                textBox4.Text = "0";
            }
            else
            {
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!char.IsNumber(textBox4.Text[i]))
                    {
                        errorpricelb.Visible = true;
                        valid = false;
                        goto End;
                    }
                }
                errorpricelb.Visible = false;
            }
        End:
            if (textBox5.Text == null || textBox5.Text == "" || textBox5.Text == " ")
            {
                textBox5.Text = "";
            }
            if (weekdayslist.SelectedItem == null)
            {
                errordaylb.Visible = true;
                valid = false;
            }
            else
            {
                errordaylb.Visible = false;
            }
                if (comboBox1.SelectedItem == null)
                {
                    errorformatlb.Visible = true;
                    valid = false;
                }
                else
                {
                    errorformatlb.Visible = false;
                }
                return valid;
        }
        public void ExitAddNewInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
            wireup_instructor();
        }
        public void ExitAddNewMaterial(Material material)
        {
            materials.Add(material);
            wireup_material();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.ParentChanged -= EditCourse_ParentChanged;
            this.Dispose(true);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Connector.connections[0].DeleteCourse(this.course.ID);
            calling.Update();
            this.ParentChanged -= EditCourse_ParentChanged;
            this.Dispose(true);
        }
        private void EditCourse_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent.Size != this.Size)
            {
                this.Size = Parent.Size;
            }
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Unkown Place") textBox5.Text = "";
        }
    }
}