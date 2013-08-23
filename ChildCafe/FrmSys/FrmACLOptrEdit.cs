using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Dal;
using ChildCafe.Common;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmACLUserEdit : XSolo.BaseForm.FrmAddEdit
    {

        public FrmACLUserEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            if (IsAdd)
            {
                cbSavePassword.Visible = false;
            }
            else
            {
                var optr = MainOptr.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(optr, tabPage1);
            }

            if(UserStatics.OptrType != "All")
            {
                ctMainOptrType.Text = UserStatics.OptrType;
            }

        }

        protected override void Saving()
        {
            //todo 判断如果用户存在，则不允许保存，提示改名
            //加密密码text
            ctPassword.Text = EncryptDecrypt.MD5(ctPassword.Text);
            if (IsAdd)
            {
                var optr = MainOptr.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(optr, tabPage1);
                optr.Save();
            }
            else
            {

                if (cbSavePassword.Checked)
                {
                    var optr = MainOptr.FindById(long.Parse(ItemID));
                    FrmAddEditBindComboBoxText.BindControlsToObject(optr, tabPage1);
                    optr.Save();
                }
                else
                {
                    var optr = MainOptr.FindById(long.Parse(ItemID));
                    optr.Name = ctName.Text;
                    optr.Description = ctDescription.Text;
                    optr.MainOptrType = ctMainOptrType.Text;
                    optr.Save();
                }


            }
        }

        private void ctMainOptrType_Click(object sender, EventArgs e)
        {
            //除了All类型用户，其他用户直接显示它的类型
            if(UserStatics.OptrType == "All")
            {
                ctMainOptrType.DataSource = UserStatics.GetUserTypes(UserStatics.OptrId);
                ctMainOptrType.DisplayMember = "Name";
            }
            else
            {
                ctMainOptrType.Text = UserStatics.OptrType;
            }

        }


    }
}
