using System;
using System.Windows.Forms;

namespace Library.UserControls
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/ElsayedHamdy");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://stackoverflow.com/users/12105732/elsayed-hamdy");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.codeproject.com/Members/User-14567920");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.c-sharpcorner.com/members/elsayed-hamdy");
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.youtube.com/channel/UC9spUFi7QkdfGwrjXAjVeIA");
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.facebook.com/48elsaydhamdy");
        }

        private void About_PaddingChanged(object sender, EventArgs e)
        {
            if (Parent.Size != this.Size)
            {
                this.Size = Parent.Size;
            }
        }
    }
}
