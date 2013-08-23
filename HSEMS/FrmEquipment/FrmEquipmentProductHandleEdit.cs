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
    public partial class FrmEquipmentProductHandleEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentProductHandleEdit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        private void FrmEquipmentProductHandleEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            if (UserStatics.OptrType == "Test")
            {
                ctIsIsolated.Checked = false;
                ctIsIsolated.Enabled = false;

                ctRetestEquipment.DataSource = BllEquipmentProductHandle.GetEquipmentNo(UserStatics.OptrType);
                ctRetestEquipment.DisplayMember = "EquipmentNo";
            }
            else
            {
                ctRetestEquipment.Enabled = false;
            }

            ctProductHandledConfirm.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "处理确认");
            ctProductHandledConfirm.DisplayMember = "Name";

            ctWhoHandled.DataSource = BllEquipmentProductHandle.GetWhoHandledByWorkShop(UserStatics.OptrType,UserStatics.WorkShop);
            ctWhoHandled.DisplayMember = "Name";

            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            ctHandleDate.Value = UserStatics.GetSqlServerDateTime();

        }

        protected override void Saving()
        {
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            //查询已修复时需包含已处理
            obj.Status = EquipmentResult.产品处理完成.ToString();
            obj.Save();
        }

        protected override void DefineControlErrors()
        {
            if (ctProductHandledConfirm.Text == "") errorProvider.SetError(ctProductHandledConfirm, "处理确认不能为空");
            else errorProvider.SetError(ctProductHandledConfirm, "");

            if (ctWhoHandled.Text == "") errorProvider.SetError(ctWhoHandled, "处理者不能为空");
            else errorProvider.SetError(ctWhoHandled, "");

            if (ctRetestEquipment.Text == "" && UserStatics.OptrType == "Test") errorProvider.SetError(ctRetestEquipment, "复测机台不能为空");
            else errorProvider.SetError(ctRetestEquipment, "");

        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
