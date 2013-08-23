using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TDAccessControl.DataAccess;
using XSolo.Common;

namespace TDAccessControl
{
    public partial class FrmACLUserEdit : XSolo.BaseForm.FrmAddEdit
    {

        public FrmACLUserEdit()
        {
            InitializeComponent();
        }

        private void FrmACLUserEdit_Load(object sender, EventArgs e)
        {
            if (!IsAdd)
            {
                var optr = MainOptr.FindById(long.Parse(ItemID));
                FrmAddEditBind.BindObjectToControls(optr,tabPage1);
            }
        }

        protected override void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            //加密密码text
            ctPassword.Text = EncryptDecrypt.MD5(ctPassword.Text);
            if(IsAdd)
            {
                var optr = MainOptr.New;
                FrmAddEditBind.BindControlsToObject(optr,tabPage1);
                optr.Save();
            }
            else
            {
                var optr = MainOptr.FindById(long.Parse(ItemID));
                FrmAddEditBind.BindControlsToObject(optr,tabPage1);
                optr.Save();

            }
        }


    }
}
