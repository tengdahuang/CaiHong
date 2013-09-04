using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;

namespace ChildCafe
{
    public partial class FrmLogin : XSolo.BaseForm.FrmBLogin
    {
        public FrmLogin()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.background;
            cbUser.DataSource = BllUserLogin.GetUserNameList();
        }

        //1.读取用户输入
        //todo 登录不用下拉框,用户名不重复
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BllUserLogin.CheckLogin(cbUser.Text, tbPassword.Text))
            {
                DialogResult = DialogResult.OK;
                var usr = BllUserLogin.GetUser(cbUser.Text);
                UserStatics.OptrName = usr.Name;
                UserStatics.OptrId = usr.Id;
                UserStatics.OptrType = usr.MainOptrType;


            }
        }
    }
}
