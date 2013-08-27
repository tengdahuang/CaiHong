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

        private void cbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void FrmBLogin_Load(object sender, EventArgs e)
        {
        }

        ///// <summary>
        ///// 整个窗体的tab用回车替代，进入使用空格
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="keyData"></param>
        ///// <returns></returns>
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    int WM_KEYDOWN = 256;
        //    int WM_SYSKEYDOWN = 260;
        //    if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
        //    {
        //        switch (keyData)
        //        {
        //            case System.Windows.Forms.Keys.Enter:
        //                SendKeys.Send("{Tab}");
        //                return true;
        //        }

        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}


    }
}
