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
    public partial class FrmEquipmentDeeQueryEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentDeeQueryEdit()
        {
            InitializeComponent();
        }

        private void FrmEquipmentDeeQueryEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            if (UserStatics.OptrType == "Test")
            {
                ctProcess.Enabled = false;
                label14.Text = "复测产量";
            }

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

        }

        protected override void Saving()
        {
            var obj = EquipmentDee.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            obj.Save();
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

            }


        }

        private void ctEquipmentNo_Click(object sender, EventArgs e)
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
    }
}
