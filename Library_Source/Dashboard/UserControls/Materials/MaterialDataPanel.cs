using System;
using System.Drawing;
using System.Windows.Forms;
namespace Library.UserControls.Materials
{
    public partial class MaterialDataPanel : UserControl
    {
        IEditMaterial calling;
        public MaterialDataPanel(IEditMaterial caller)
        {
            InitializeComponent();
            calling = caller;
        }
        private void Rowdatabarpl_MouseEnter(object sender, EventArgs e)
        {
            rowdatabarpl.BackColor = SystemColors.ControlDark;
        }
        private void Rowdatabarpl_MouseLeave(object sender, EventArgs e)
        {
            rowdatabarpl.BackColor = SystemColors.MenuHighlight;
        }
        private void Rowdatabarpl_Click(object sender, EventArgs e)
        {
            rowdatabarpl.Focus();
        }
        private void LecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.Open(this, "lecture");
        }
        private void SectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.Open(this, "section");
        }
        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.Open(this, "book");
        }
        private void InstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.Open(this, "instructor");
        }
        private void CoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.Open(this, "course");
        }
        private void EditToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            editToolStripMenuItem.Image = Properties.Resources.edit2;
        }
        private void EditToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            editToolStripMenuItem.Image = Properties.Resources.edit1;
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.EditMaterial(this);
        }
    }
}
