using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XSolo.ModuleActions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FrmLogin login = new FrmLogin();
            //login.ShowDialog();
            //if (login.DialogResult.Equals(DialogResult.OK))
            //{
            //    login.Dispose();
                Application.Run(new FrmACLMain());
            //}
        }
    }
}
