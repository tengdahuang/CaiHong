using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Dal;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmACLActionEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmACLActionEdit()
        {
            InitializeComponent();
        }

        private void FrmACLActionEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            if (!IsAdd)
            {
                var optr = MainAction.FindById(long.Parse(ItemID));
                FrmAddEditBind.BindObjectToControls(optr, tabPage1);
            }
        }

        protected override void Saving()
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
