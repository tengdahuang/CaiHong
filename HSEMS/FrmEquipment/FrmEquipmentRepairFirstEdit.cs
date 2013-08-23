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
    public partial class FrmEquipmentRepairFirstEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentRepairFirstEdit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        private void cbRemainingProblem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemainingProblem.Checked)
            {
                ctRemainingProblem.Enabled = true;
            }
            else
            {
                ctRemainingProblem.Enabled = false;
            }
        }

        private void FrmEquipmentRepairFirstEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {

            ctAssist1.DataSource = BllEquipmentRepairFirst.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAssist1.DisplayMember = "Name";

            ctResultConfirm.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "效果确认");
            ctResultConfirm.DisplayMember = "Name";

            ctFailureType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "故障分类");
            ctFailureType.DisplayMember = "Name";

            ctProductHandle.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "产品处理");
            ctProductHandle.DisplayMember = "Name";

            ctMonitor1.DataSource = BllEquipmentRepairFirst.GetRepairMonitorByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctMonitor1.DisplayMember = "Name";

            ctRestoreDate1.Value = UserStatics.GetSqlServerDateTime();
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            
        }

        protected override void Saving()
        {
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            TimeSpan ts = ctRestoreDate1.Value - ctAcceptDate.Value;
            obj.RepairingTakes1 = Math.Ceiling(ts.TotalMinutes);

            if  (ctProductHandle.Text == "前批隔离/本批复测")
            {
                obj.Status = EquipmentResult.产品处理.ToString();
                obj.Save();
            }
            else if (ctResultConfirm.Text == EquipmentResult.未修复.ToString())
            {
                obj.Status = EquipmentResult.未修复.ToString();
                obj.Save();
            }
            else if ( cbRemainingProblem.Checked && ctRemainingProblem.Text != "")
            {
                obj.Status = EquipmentResult.遗留问题.ToString();
                obj.Save();
            }
            else
            {
                obj.Status = EquipmentResult.已修复.ToString();
                obj.Save();
            }
            
        }

        protected override void DefineControlErrors()
        {

            if (ctResultConfirm.Text == "") errorProvider.SetError(ctResultConfirm, "效果确认不能为空");
            else errorProvider.SetError(ctResultConfirm, "");

            if (ctFailureType.Text == "") errorProvider.SetError(ctFailureType, "故障分类不能为空");
            else errorProvider.SetError(ctFailureType, "");

            if (ctMonitor1.Text == "") errorProvider.SetError(ctMonitor1, "当班班长1不能为空");
            else errorProvider.SetError(ctMonitor1, "");
            
        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
