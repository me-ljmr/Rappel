using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rappel.Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (frmServiceManager.RunningInstance() != null)
            {
                MessageBox.Show("An instance of the application is already running.", Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmServiceManager());
            }
        }
    }
}
