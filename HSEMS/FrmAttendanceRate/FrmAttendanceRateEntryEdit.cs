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
    public partial class FrmAttendanceRateEntryEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmAttendanceRateEntryEdit()
        {
            InitializeComponent();
        }

        private void FrmAttendanceRateEntryEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            ctDistrict.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "区域");
            ctDistrict.DisplayMember = "Name";

            ctGroupMonitor.DataSource = BllAttendanceRate.GetGroupMonitorByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctGroupMonitor.DisplayMember = "Name";


            if (!IsAdd)
            {
                var obj = AttendanceRate.FindById(long.Parse(ItemID));
                BindControlsDecimal.BindObjectToControls(obj, tabPage1);
                ReSetNumbericUpDownStatus();
            }
            else 
            { ctInputDate.Value = UserStatics.GetSqlServerDateTime(); }

        }

        protected override void Saving()
        {
            if (IsAdd)
            {
                var obj = AttendanceRate.New;
                BindControlsDecimal.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();
            }
            else if (IsAdd == false)
            {
                var obj = AttendanceRate.FindById(long.Parse(ItemID));
                BindControlsDecimal.BindControlsToObject(obj, tabPage1);
                obj.Save();
            }

        }

        protected override void AfterSave()
        {
            string message = "保存后是否继续新增?";
            string caption = "提醒";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //遍历数值控件赋值和置0
                ResetNumbericUpdown();
                ReSetNumbericUpDownStatus();

                ctDistrict.Focus();
                //重置时间
                ctInputDate.Value = UserStatics.GetSqlServerDateTime();

            }
            else
            {
                this.Close();
            }

        }

        private void ctDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReSetNumbericUpDownStatus();
        }


        private void ReSetNumbericUpDownStatus()
        {
            switch (ctDistrict.Text.ToString())
            {
                case "部门":
                    BindControlsDecimal.DisableNumbericUpDown(tabPage1);
                    ctManagementPerson.Enabled = true;
                    ctTechnicalPerson.Enabled = true;
                    ctAuxiliaryPerson.Enabled = true;
                    ctLowPowerTestOutput.Enabled = true;
                    ctLowPowerPrintOutput.Enabled = true;
                    label9.Text = "大功率操作工";
                    label11.Text = "小功率操作工";
                    ctLowPowerOperator.Enabled = true;
                    ctBraidingOutput.Enabled = true;
                    ctHighPowerDelivery.Enabled = true;
                    ctHighPowerOrder.Enabled = true;
                    ctMidPowerDelivery.Enabled = true;
                    ctMidPowerOrder.Enabled = true;
                    ctLowPowerDelivery.Enabled = true;
                    ctLowPowerOrder.Enabled = true;
                    ctGroupMonitor.Enabled = false;
                    ctAbnormalPerson.Enabled = false;
                    ctAbnormalReason.Enabled = false;
                    break;
                case "包装":
                    BindControlsDecimal.DisableNumbericUpDown(tabPage1);
                    ctGroupMonitor.Enabled = true;
                    ctManagementPerson.Enabled = true;
                    ctAuxiliaryPerson.Enabled = true;
                    ctHighPowerOperator.Enabled = true;
                    ctLowPowerOperator.Enabled = true;
                    label9.Text = "全检操作工";
                    label11.Text = "合批操作工";
                    ctNewOperator.Enabled = true;
                    ctAbsencePerson.Enabled = true;
                    ctPackageFullInspectionOutput.Enabled = true;
                    ctPackageCombineOutput.Enabled = true;
                    ctAbnormalPerson.Enabled = true;
                    break;
                case "测试":
                    BindControlsDecimal.DisableNumbericUpDown(tabPage1);
                    ctGroupMonitor.Enabled = true;
                    ctManagementPerson.Enabled = true;
                    ctHighPowerOperator.Enabled = true;
                    ctNewOperator.Enabled = true;
                    ctAbsencePerson.Enabled = true;
                    ctHighPowerTestOutput.Enabled = true;
                    ctAbnormalPerson.Enabled = true;
                    label9.Text = "大功率操作工";
                    label11.Text = "小功率操作工";
                    break;
            }
        }

        private void ctHighPowerTestOutput_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).ToString().Length);
        }

    }
}
