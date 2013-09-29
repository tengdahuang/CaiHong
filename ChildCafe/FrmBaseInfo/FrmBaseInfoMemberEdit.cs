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
    public partial class FrmBaseInfoMemberEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmBaseInfoMemberEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {

            if (!IsAdd)
            {
                var obj = BaseInfoMember.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            }
            else
            {
                ctDiscountRate.Value = 100;
                ctJoinedDate.Value = DateTime.Now.Date;
            }

        }

        protected override void Saving()
        {
            if (IsAdd)
            {

                var obj = BaseInfoMember.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();


            }
            else
            {

                var obj = BaseInfoMember.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();

            }
        }

        protected override void DefineControlErrors()
        {
            if (ctCardNumber.Text == "") errorProvider.SetError(ctCardNumber, "卡号不能为空");
            else errorProvider.SetError(ctCardNumber, "");
            if (ctMemberName.Text == "") errorProvider.SetError(ctMemberName, "姓名不能为空");
            else errorProvider.SetError(ctMemberName, "");
            if (ctMobile.Text == "") errorProvider.SetError(ctMobile, "手机不能为空");
            else errorProvider.SetError(ctMobile, "");
        }

        private void ctName_TextChanged(object sender, EventArgs e)
        {
            ctPinYin.Text = AutoPinYin.GetPinYin(ctMemberName.Text);
        }

        protected override void AfterSave()
        {
            this.Close();
        }


    }
}
