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
    public partial class FrmEquipmentInformationEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentInformationEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            if(UserStatics.OptrType != "Package")
            {
                ctModeNo.Enabled = false;
            }

            if (UserStatics.OptrType == "Package" || UserStatics.OptrType == "Assembly")
            {
                ctTestStation.Enabled = false;
                ctChannelCount.Enabled = false;
            }

            if(UserStatics.OptrType == "Test")
            {
                ctProcess.Enabled = false;
            }

            ctEquipmentType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "设备分类");
            ctEquipmentType.DisplayMember = "Name";

            ctProductAdaptation.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "适应产品");
            ctProductAdaptation.DisplayMember = "Name";

            ctCondition.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "使用状态");
            ctCondition.DisplayMember = "Name";

            ctManagementGroup.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "管理分组");
            ctManagementGroup.DisplayMember = "Name";

            ctProcess.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工序");
            ctProcess.DisplayMember = "Name";

            ctDeviceClass.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "设备分级");
            ctDeviceClass.DisplayMember = "Name";

            ctStatisticalClass.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "统计分类");
            ctStatisticalClass.DisplayMember = "Name";

            ctManufacturer.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "制造厂家");
            ctManufacturer.DisplayMember = "Name";

            if (!IsAdd)
            {
                var obj = EquipmentInformation.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            }

        }

        protected override void Saving()
        {
            if (IsAdd)
            {

                var obj = EquipmentInformation.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                if (UserStatics.OptrType == "Test")
                {
                    obj.Process = "测试";
                }
                obj.Save();


            }
            else
            {

                var obj = EquipmentInformation.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                if (UserStatics.OptrType == "Test")
                {
                    obj.Process = "测试";
                }
                obj.Save();

            }
        }

        protected override void DefineControlErrors()
        {
            if (ctEquipmentNo.Text == "") errorProvider.SetError(ctEquipmentNo, "机台号不能为空");
            else errorProvider.SetError(ctEquipmentNo, "");
            if (ctModel.Text == "") errorProvider.SetError(ctModel, "设备型号不能为空");
            else errorProvider.SetError(ctModel, "");
            if (ctProductAdaptation.Text == "") errorProvider.SetError(ctProductAdaptation, "适应产品不能为空");
            else errorProvider.SetError(ctProductAdaptation, "");
            if (ctCondition.Text == "") errorProvider.SetError(ctCondition, "使用状态不能为空");
            else errorProvider.SetError(ctCondition, "");
            if (ctManufacturer.Text == "") errorProvider.SetError(ctManufacturer, "制造厂家不能为空");
            else errorProvider.SetError(ctManufacturer, "");
        }




    }
}
