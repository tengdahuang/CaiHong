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
    public partial class FrmEquipmentVariationDistribution : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentVariationDistribution()
        {
            IsAdd = true;
            InitializeComponent();
        }

        private void FrmEquipmentVariationDistribution_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {

            if (UserStatics.OptrType == "Test")
            {
                ctProcess.Enabled = false;

                ctEquipmentNo.DataSource = BllEquipmentVariation.GetEquipmentNoByProcess(UserStatics.OptrType,"测试");
                ctEquipmentNo.DisplayMember = "EquipmentNo";
                
            }


            ctProcess.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工序");
            ctProcess.DisplayMember = "Name";

            ctVariationType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "变更类别");
            ctVariationType.DisplayMember = "Name";

            ctVariationReason.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "变更原因");
            ctVariationReason.DisplayMember = "Name";

            ctDistributor.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "变更安排人");
            ctDistributor.DisplayMember = "Name";

            ctDistributeDate.Value = DateTime.Now;
        }

        private void ctProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserStatics.OptrType == "Package" || UserStatics.OptrType == "Assembly")
            {
                //机台号每个工序都会不同
                ctEquipmentNo.DataSource = BllEquipmentVariation.GetEquipmentNoByProcess(UserStatics.OptrType, ctProcess.Text);
                ctEquipmentNo.DisplayMember = "EquipmentNo";

            }
        }

        protected override void Saving()
        {
            if (IsAdd)
            {

                var obj = EquipmentVariation.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Status = VariationResult.已安排.ToString();
                obj.WaitingTakes = 0;
                obj.VariationTakes1 = 0;
                obj.VariationTakes2 = 0;
                obj.Save();
            }

        }

        protected override void AfterSave()
        {
            ClearControls();
        }

        protected override void DefineControlErrors()
        {
            if (UserStatics.OptrType == "Test")
            {
                if (ctEquipmentNo.Text == "") errorProvider.SetError(ctEquipmentNo, "机台号不能为空");
                else errorProvider.SetError(ctEquipmentNo, "");
                if (ctVariationType.Text == "") errorProvider.SetError(ctVariationType, "变更类型不能为空");
                else errorProvider.SetError(ctVariationType, "");
                if (ctVariationReason.Text == "") errorProvider.SetError(ctVariationReason, "变更原因不能为空");
                else errorProvider.SetError(ctVariationReason, "");
                if (ctDistributor.Text == "") errorProvider.SetError(ctDistributor, "安排人不能为空");
                else errorProvider.SetError(ctDistributor, "");
                if (ctBeforeVariation.Text == "") errorProvider.SetError(ctBeforeVariation, "'变更前'不能为空");
                else errorProvider.SetError(ctBeforeVariation, "");
                if (ctAfterVariation.Text == "") errorProvider.SetError(ctAfterVariation, "'变更后'不能为空");
                else errorProvider.SetError(ctAfterVariation, "");
            }


        }


    }
}
