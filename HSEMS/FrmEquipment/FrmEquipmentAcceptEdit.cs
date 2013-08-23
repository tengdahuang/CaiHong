using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Common;
using HSEMS.Dal;
using HSEMS.Bll;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmEquipmentAcceptEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentAcceptEdit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        protected override void Loading()
        {
            ctAcceptDate.Value = UserStatics.GetSqlServerDateTime();
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);

            ctAccepter1.DataSource = BllEquipmentAccept.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAccepter1.DisplayMember = "Name";

        }

        protected override void Saving()
        {
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj,tabPage1);
            TimeSpan ts = ctAcceptDate.Value - ctNoticeDate.Value;
            obj.WaitingTakes = Math.Ceiling(ts.TotalMinutes);
            obj.Status = EquipmentResult.已接单.ToString();
            obj.Save();

        }

        protected override void DefineControlErrors()
        {
            if (ctAccepter1.Text == "") errorProvider.SetError(ctAccepter1, "接单人不能为空");
            else errorProvider.SetError(ctAccepter1, "");

        }

        protected override void AfterSave()
        {
            this.Close();
        }

        private void FrmEquipmentAcceptEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
