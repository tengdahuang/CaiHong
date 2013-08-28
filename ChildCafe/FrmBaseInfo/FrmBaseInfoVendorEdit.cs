using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Common;
using ChildCafe.Dal;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoVendorEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmBaseInfoVendorEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            if (!IsAdd)
            {
                var obj = BaseInfoVendor.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            }
        }

        protected override void Saving()
        {
            if (IsAdd)
            {

                var obj = BaseInfoVendor.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();


            }
            else
            {

                var obj = BaseInfoVendor.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();

            }
        }

        protected override void DefineControlErrors()
        {
            if (ctName.Text == "") errorProvider.SetError(ctName, "供应商名称不能为空");
            else errorProvider.SetError(ctName, "");
        }

        private void ctName_TextChanged(object sender, EventArgs e)
        {
            ctShortCode.Text = AutoPinYin.GetPinYin(ctName.Text);
        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
