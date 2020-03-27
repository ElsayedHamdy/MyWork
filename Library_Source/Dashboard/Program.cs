using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static bool good       = false;
        [STAThread]
        static void Main()
        {
            if ((Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1) && (Library.Properties.Settings.Default.restarting == false))
            {
                    if (MessageBox.Show("You Have Currently Running Instance of the Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) Environment.Exit(0);
                    else Environment.Exit(0);
            }
            Library.Properties.Settings.Default.restarting = false;
            Library.Properties.Settings.Default.Save();
            if (Screen.PrimaryScreen.Bounds.Width < 817 || Screen.PrimaryScreen.Bounds.Height < 720)
            {
                if (MessageBox.Show("Sorry This Appalication Requires Minimum Display Resolution of (817 x 720) pixel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    good = false;
                    Environment.Exit(0);
                }
                else
                {
                    good = false;
                    Environment.Exit(0);
                }
            }
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
            {
                int releaseKey = System.Convert.ToInt32(ndpKey.GetValue("Release"));
                if (releaseKey >= 461808)
                {
                    SqlConnection connection;
                    try
                    {
                        connection = new SqlConnection(Connector.CnnString("Library"));
                        connection.Open();
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                            connection.Dispose();
                            good = true;
                        }
                        else
                        {
                            connection.Close();
                            connection.Dispose();
                            good = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            good = false;
                            Environment.Exit(0);
                        }
                        else
                        {
                            good = false;
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Please Make sure of Installing .Net Framework 4.7.2 or Higher Verision.", "Error .Net Framework 4.7.2 not Installed", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start(@"http://go.microsoft.com/fwlink/?linkid=863265");
                        good = false;
                        Environment.Exit(0);
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(@"http://go.microsoft.com/fwlink/?linkid=863265");
                        good = false;
                        Environment.Exit(0);
                    }
                }
            }
            if(good)
            {
                Library.Connector.Initialize(true, false);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Dashboard());
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
