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
    public partial class FrmEquipmentDeeEntryEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentDeeEntryEdit()
        {
            InitializeComponent();
        }

        private void FrmEquipmentDeeEntry_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            toolStripStatusLabel1.Text = toolStripStatusLabel1.Text + ",按F7选机台。";
            if (UserStatics.OptrType == "Test")
            {
                ctCurrentProduct.Enabled = false;
                ctProcess.Enabled = false;
                label14.Text = "复测产量";
            }
            else
            {
                ctProcess.Enabled = false;
            }

            ctProductAdaptation.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "适应产品");
            ctProductAdaptation.DisplayMember = "Name";

            ctProcess.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工序");
            ctProcess.DisplayMember = "Name";

            ctGrouping.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "班组");
            ctGrouping.DisplayMember = "Name";

            ctRepairMonitor.DataSource = BllEquipmentDee.GetRepairMonitorByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctRepairMonitor.DisplayMember = "Name";

            ctGroupMonitor.DataSource = BllEquipmentDee.GetGroupMonitorByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctGroupMonitor.DisplayMember = "Name";

            ctOperator.DataSource = BllEquipmentDee.GetOperatorByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctOperator.DisplayMember = "Name";



            if (!IsAdd)
            {
                var obj = EquipmentDee.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            }
            else { ctDeeDate.Value = DateTime.Now.AddDays(-1); }
        }


        protected override void Saving()
        {
            if (IsAdd)
            {
                var obj = EquipmentDee.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();
            }
            else if (IsAdd == false)
            {
                var obj = EquipmentDee.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
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
                //遍历数值控件并置0
                ResetNumbericUpdown();

                ctEquipmentNo.Focus();
                //弹出机台选择窗口
                PerformClick();
                //重置时间
                ctDeeDate.Value = DateTime.Now.AddDays(-1);

            }
            else
            {
                this.Close();
            }

        }

        protected override void DefineControlErrors()
        {
            if (UserStatics.OptrType == "Test")
            {
                if (ctEquipmentNo.Text == "") errorProvider.SetError(ctEquipmentNo, "机台号不能为空");
                else errorProvider.SetError(ctEquipmentNo, "");
            }
        }

        private void ctEquipmentNo_Click(object sender, EventArgs e)
        {
            PerformClick();
        }

        private void PerformClick()
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

        private void FrmEquipmentDeeEntryEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                PerformClick();
            }
        }

        private void ctUnitsPerHour_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).ToString().Length);
        }
    }
}
