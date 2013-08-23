using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmMainChangePassword : Form
    {
        public FrmMainChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BllMainChangePassword.CheckOldPass(UserStatics.OptrId, tbOldPassword.Text) == false)
            {
                MessageBox.Show("您输入的旧密码错误，请重输!");
            }
            else if (tbNewPassword1.Text != tbNewPassword2.Text)
            {
                MessageBox.Show("您两次输入的新密码不同，请重输!");
            }
            else
            {
                BllMainChangePassword.SaveNewPass(UserStatics.OptrId, tbNewPassword1.Text);
                MessageBox.Show("密码已更改!");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
