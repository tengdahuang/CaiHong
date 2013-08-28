using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XSolo.BaseForm
{
    public partial class FrmBLogin : Form
    {
        public FrmBLogin()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.iconMain;
        }

        private void CloseMe()
        {
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseMe();
        }



        private void FrmBLogin_Load(object sender, EventArgs e)
        {
        }


        private void FrmBLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

    }
}
