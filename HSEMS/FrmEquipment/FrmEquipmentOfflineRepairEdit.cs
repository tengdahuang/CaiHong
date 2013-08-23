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
    public partial class FrmEquipmentOfflineRepairEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentOfflineRepairEdit()
        {
            InitializeComponent();
        }

        private void FrmEquipmentOfflineRepairEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            if(!IsAdd)
            {

                ctOfflineResultConfirm.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "离线效果确认");
                ctOfflineResultConfirm.DisplayMember = "Name";

                ctOfflineWhoRepaired.DataSource = BllEquipmentOffline.GetWhoNotice(UserStatics.OptrType);
                ctOfflineWhoRepaired.DisplayMember = "Name";

                var obj = EquipmentOffline.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);

                ctOfflineRepairDate.Value = UserStatics.GetSqlServerDateTime();
            }

        }


        protected override void Saving()
        {
            if (!IsAdd)
            {
                var obj = EquipmentOffline.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
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
                if (ctOfflineRepairRecord.Text == "") errorProvider.SetError(ctOfflineRepairRecord, "维修记录不能为空");
                else errorProvider.SetError(ctOfflineRepairRecord, "");
                if (ctOfflineResultConfirm.Text == "") errorProvider.SetError(ctOfflineResultConfirm, "效果确认不能为空");
                else errorProvider.SetError(ctOfflineResultConfirm, "");
                if (ctOfflineWhoRepaired.Text == "") errorProvider.SetError(ctOfflineWhoRepaired, "修复人不能为空");
                else errorProvider.SetError(ctOfflineWhoRepaired, "");
            }


        }
    }
}
