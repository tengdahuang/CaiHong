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
            //if (ctEquipmentNo.Text == "") errorProvider.SetError(ctEquipmentNo, "机台号不能为空");
            //else errorProvider.SetError(ctEquipmentNo, "");
            //if (ctModel.Text == "") errorProvider.SetError(ctModel, "设备型号不能为空");
            //else errorProvider.SetError(ctModel, "");
            //if (ctProductAdaptation.Text == "") errorProvider.SetError(ctProductAdaptation, "适应产品不能为空");
            //else errorProvider.SetError(ctProductAdaptation, "");
            //if (ctCondition.Text == "") errorProvider.SetError(ctCondition, "使用状态不能为空");
            //else errorProvider.SetError(ctCondition, "");
            //if (ctManufacturer.Text == "") errorProvider.SetError(ctManufacturer, "制造厂家不能为空");
            //else errorProvider.SetError(ctManufacturer, "");
        }

        private void ctName_TextChanged(object sender, EventArgs e)
        {
            ctPinYin.Text = AutoPinYin.GetPinYin(ctName.Text);
        }

        protected override void AfterSave()
        {
            this.Close();
        }


    }
}
