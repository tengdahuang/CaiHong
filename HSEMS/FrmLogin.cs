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
    public partial class FrmLogin : XSolo.BaseForm.FrmBLogin
    {
        public FrmLogin()
        {
            InitializeComponent();
            cbUser.DataSource = BllUserLogin.GetUserNameList();
        }

        //1.读取用户输入
        //todo 登录不用下拉框,用户名不重复
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var ul = new BllUserLogin();
            if (ul.CheckLogin(cbUser.Text, tbPassword.Text))
            {
                DialogResult = DialogResult.OK;
                var usr = BllUserLogin.GetUser(cbUser.Text);
                UserStatics.OptrName = usr.Name;
                UserStatics.OptrId = usr.Id;
                UserStatics.OptrType = usr.MainOptrType;
                if (UserStatics.OptrType == "Test")
                    UserStatics.WorkShop = "测试区";
                if (UserStatics.OptrType == "Package")
                    UserStatics.WorkShop = "塑封区";
                if (UserStatics.OptrType == "Assembly")
                    UserStatics.WorkShop = "装配区";

            }
        }
    }
}
