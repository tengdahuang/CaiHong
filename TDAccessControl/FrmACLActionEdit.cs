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
    public partial class FrmACLActionEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmACLActionEdit()
        {
            InitializeComponent();
        }

        private void FrmACLActionEdit_Load(object sender, EventArgs e)
        {
            if (!IsAdd)
            {
                var optr = MainAction.FindById(long.Parse(ItemID));
                FrmAddEditBind.BindObjectToControls(optr, tabPage1);
            }
        }

        protected override void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                var optr = MainAction.New;
                FrmAddEditBind.BindControlsToObject(optr, tabPage1);
                optr.Save();
            }
            else
            {
                var optr = MainAction.FindById(long.Parse(ItemID));
                FrmAddEditBind.BindControlsToObject(optr, tabPage1);
                optr.Save();

            }
        }
    }
}
