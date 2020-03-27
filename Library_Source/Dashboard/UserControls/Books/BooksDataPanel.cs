using System;
using System.Drawing;
using System.Windows.Forms;
namespace Library.UserControls.Books
{
    public partial class BooksDataPanel : UserControl
    {
        IEditBook calling;
        public BooksDataPanel(IEditBook caller)
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
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.Open(this, "Book");
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calling.EditBook(this);
        }
        private void EditToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            editToolStripMenuItem.Image = Properties.Resources.edit2;
        }
        private void EditToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            editToolStripMenuItem.Image = Properties.Resources.edit1;
        }
        private void rowdatabarpl_Click(object sender, EventArgs e)
        {
            rowdatabarpl.Focus();
        }
    }
}
