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
    public partial class FrmEquipmentOfflineApply : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentOfflineApply()
        {
            IsAdd = true;
            InitializeComponent();
        }

        private void FrmEquipmentOfflineApply_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            ctEquipmentNo.DataSource = BllEquipmentOffline.GetEquipmentNo(UserStatics.OptrType);
            ctEquipmentNo.DisplayMember = "EquipmentNo";

            ctEquipmentType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "设备分类");
            ctEquipmentType.DisplayMember = "Name";

            ctWhoApplied.DataSource = BllEquipmentOffline.GetWhoNotice(UserStatics.OptrType);
            ctWhoApplied.DisplayMember = "Name";


            ctOfflineDate.Value = UserStatics.GetSqlServerDateTime();
        }


        protected override void Saving()
        {
            if (IsAdd)
            {
                var obj = EquipmentOffline.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.OfflineRepairDate = Convert.ToDateTime("1900-01-01 00:00:01");
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
                if (ctEquipmentType.Text == "") errorProvider.SetError(ctEquipmentType, "设备分类不能为空");
                else errorProvider.SetError(ctEquipmentType, "");
                if (ctOfflineReason.Text == "") errorProvider.SetError(ctOfflineReason, "离线原因不能为空");
                else errorProvider.SetError(ctOfflineReason, "");
                if (ctWhoApplied.Text == "") errorProvider.SetError(ctWhoApplied, "提交人不能为空");
                else errorProvider.SetError(ctWhoApplied, "");
            }


        }
    }
}
