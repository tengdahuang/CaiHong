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
    public partial class FrmEquipmentRepairSecondEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentRepairSecondEdit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        private void FrmEquipmentRepairSecondEdit_Load(object sender, EventArgs e)
        {

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

        protected override void Loading()
        {
            ctAccepter2.DataSource = BllEquipmentRepairSecond.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAccepter2.DisplayMember = "Name";

            ctAssist2.DataSource = BllEquipmentRepairSecond.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAssist2.DisplayMember = "Name";

            ctResultConfirm.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "效果确认");
            ctResultConfirm.DisplayMember = "Name";

            ctFailureType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "故障分类");
            ctFailureType.DisplayMember = "Name";

            ctProductHandle.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "产品处理");
            ctProductHandle.DisplayMember = "Name";

            ctMonitor2.DataSource = BllEquipmentRepairSecond.GetRepairMonitorByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctMonitor2.DisplayMember = "Name";

            ctRestoreDate2.Value = UserStatics.GetSqlServerDateTime();
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);

        }

        protected override void Saving()
        {
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            TimeSpan ts = ctRestoreDate2.Value - (DateTime)(obj.RestoreDate1);
            obj.RepairingTakes2 = Math.Ceiling(ts.TotalMinutes);

            if (ctResultConfirm.Text == "未修复")
            {
                obj.Status = EquipmentResult.未修复.ToString();
                obj.Save();
                MessageBox.Show("设备维修未修复!");
            }
            else if (ctProductHandle.Text == "前批隔离/本批复测")
            {
                obj.Status = EquipmentResult.产品处理.ToString();
                obj.Save();
            }
            else if (cbRemainingProblem.Checked && ctRemainingProblem.Text != "")
            {
                //todo: 查询"修复完成"时，需要统计同时查询遗留问题
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
            //if (ctResultConfirm.Text == EquipmentResult.未修复.ToString() && ctProductHandle.Text == "前批隔离/本批复测")
            //{
            //    errorProvider.SetError(ctProductHandle, "未修复和前批隔离/本批复测冲突");
            //}
            //else
            //{
            //    errorProvider.SetError(ctResultConfirm, "");
            //    errorProvider.SetError(ctProductHandle, "");
            //}

            if (ctResultConfirm.Text == "未修复") errorProvider.SetError(ctResultConfirm, "不允许二次未修复");
            else errorProvider.SetError(ctResultConfirm, "");

            if (ctAccepter2.Text == "") errorProvider.SetError(ctAccepter2, "修复者2不能为空");
            else errorProvider.SetError(ctAccepter2, "");

            if (ctResultConfirm.Text == "") errorProvider.SetError(ctResultConfirm, "效果确认不能为空");
            else errorProvider.SetError(ctResultConfirm, "");

            if (ctFailureType.Text == "") errorProvider.SetError(ctFailureType, "故障分类不能为空");
            else errorProvider.SetError(ctFailureType, "");

            if (ctMonitor2.Text == "") errorProvider.SetError(ctMonitor2, "当班班长2不能为空");
            else errorProvider.SetError(ctMonitor2, "");

        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
