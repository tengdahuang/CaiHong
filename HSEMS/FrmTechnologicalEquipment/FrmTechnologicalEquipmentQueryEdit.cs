using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Dal;
using HSEMS.Common;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmTechnologicalEquipmentQueryEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmTechnologicalEquipmentQueryEdit()
        {
            IsAdd = true;
            InitializeComponent();
        }

        private void FrmTechnologicalEquipmentQueryEdit_Load(object sender, EventArgs e)
        {

        }

        private void RaiseSearchWindow()
        {
            FrmEquipmentInformation fei = new FrmEquipmentInformation(); ;
            fei.IsSelect = true;
            fei.ShowDialog();
            //返回的SelectedValue,取出SelectedValue的EquipmentInformation
            EquipmentInformation ei = EquipmentInformation.FindById(fei.SelectedValue);
            //绑定各个控件
            FrmAddEditBindComboBoxText.BindObjectToControls(ei, tabPage1);
            fei.Dispose();
        }

        protected override void Loading()
        {
            if (UserStatics.OptrType == "Test")
            {
                ctModeNo.Enabled = false;
                ctProductType.Enabled = false;
            }

            ctProductType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "适应产品");
            ctProductType.DisplayMember = "Name";

            ctTechnologicalEquipmentType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工装类型");
            ctTechnologicalEquipmentType.DisplayMember = "Name";

            ctWhoInstalled.DataSource = BllTechnologicalEquipment.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctWhoInstalled.DisplayMember = "Name";

            ctWhoUninstalled.DataSource = BllTechnologicalEquipment.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctWhoUninstalled.DisplayMember = "Name";

            var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);


            ctTeHandle.Text = "在用";
        }

        protected override void Saving()
        {
            if (!IsAdd)
            {
                var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.TeHandle = "在用";
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
                if (ctTechnologicalEquipmentType.Text == "") errorProvider.SetError(ctTechnologicalEquipmentType, "工装类型不能为空");
                else errorProvider.SetError(ctTechnologicalEquipmentType, "");
                if (ctWhoInstalled.Text == "") errorProvider.SetError(ctWhoInstalled, "安装人不能为空");
                else errorProvider.SetError(ctWhoInstalled, "");
                if (ctUpperLimitCount.Value > 1000000 && ctTechnologicalEquipmentType.Text == "成型刀") errorProvider.SetError(ctUpperLimitCount, "成型刀寿命上限超过100万，请确认输入是否正确");
                else errorProvider.SetError(ctUpperLimitCount, "");
            }


        }

        private void ctTechnologicalEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctTechnologicalEquipmentType.Text.StartsWith("测试爪"))
            {
                ctLowerLimitCount.Value = 9700000;
                ctUpperLimitCount.Value = 10100000;
                ctTechnologicalEquipmentStatus.Enabled = false;
            }
            if (ctTechnologicalEquipmentType.Text == "成型刀")
            {
                ctLowerLimitCount.Value = 550000;
                ctUpperLimitCount.Value = 610000;
                ctTechnologicalEquipmentStatus.Enabled = true;
            }
        }

        private void ctEquipmentNo_Click(object sender, EventArgs e)
        {
            RaiseSearchWindow();
        }

    }
}
