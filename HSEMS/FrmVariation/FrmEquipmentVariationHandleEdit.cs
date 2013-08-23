using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Common;
using HSEMS.Dal;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmEquipmentVariationHandleEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentVariationHandleEdit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        private void FrmEquipmentVariationHandleEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {

            ctAssist.DataSource = BllEquipmentVariationHandle.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAssist.DisplayMember = "Name";

            ctResultConfirm.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "变更效果确认");
            ctResultConfirm.DisplayMember = "Name";

            ctTester.DataSource = BllEquipmentVariationHandle.GetEquipmentType(UserStatics.OptrType, "测试仪");
            ctTester.DisplayMember = "EquipmentNo";

            ctFinishDate1.Value = DateTime.Now;
            var obj = EquipmentVariation.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);

        }

        protected override void Saving()
        {
            var obj = EquipmentVariation.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            TimeSpan ts = ctFinishDate1.Value - ctAcceptDate.Value;
            obj.VariationTakes1 = Math.Ceiling(ts.TotalMinutes);

            if (ctResultConfirm.Text == VariationResult.未完成.ToString())
            {
                obj.Status = VariationResult.未完成.ToString();
                obj.Save();
            }
            else
            {
                obj.Status = VariationResult.已完成.ToString();
                obj.Save();
            }

        }

        protected override void DefineControlErrors()
        {

            if (ctResultConfirm.Text == "") errorProvider.SetError(ctResultConfirm, "变更效果确认不能为空");
            else errorProvider.SetError(ctResultConfirm, "");

            if (ctVariationContent1.Text == "") errorProvider.SetError(ctVariationContent1, "处理内容不能为空");
            else errorProvider.SetError(ctVariationContent1, "");

        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
