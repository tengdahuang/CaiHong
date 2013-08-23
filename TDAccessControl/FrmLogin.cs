using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TDAccessControl.BLL;
using Lephone.Data;
using TDAccessControl.TestCode;

namespace TDAccessControl
{
    public partial class FrmLogin : XSolo.BaseForm.FrmBLogin
    {
        public FrmLogin()
        {
            InitializeComponent();
            //绑定用户列表
            cbUser.DataSource = BllUserLogin.GetUserNameList();


            //AccessSystem or = new AccessSystem();
            //or.AddOptrsAndRoles();

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(cbUser.Text != "root" && cbUser.Text != "TestAdmin" && cbUser.Text!= "PackageAdmin")
            {
                MessageBox.Show("该功能只有管理员能够使用，请联系管理员");
                Application.Exit();
            }
            var ul = new BllUserLogin();
            if (ul.CheckLogin(cbUser.Text,tbPassword.Text))
            {
                DialogResult = DialogResult.OK;
                var usr = BllUserLogin.GetUserName(cbUser.Text);
                Common.UserStatics.Username = usr.Name;
                Common.UserStatics.UserId = usr.Id;

            }
        }
    }
}
