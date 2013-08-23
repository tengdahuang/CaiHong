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
    public partial class FrmEquipmentVariationAcceptEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentVariationAcceptEdit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        protected override void Loading()
        {
            ctAcceptDate.Value = DateTime.Now;
            var obj = EquipmentVariation.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);

            ctAccepter1.DataSource = BllEquipmentVariationAccept.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAccepter1.DisplayMember = "Name";

        }

        protected override void Saving()
        {
            var obj = EquipmentVariation.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            TimeSpan ts = ctAcceptDate.Value - ctDistributeDate.Value;
            obj.WaitingTakes = Math.Ceiling(ts.TotalMinutes);
            obj.Status = VariationResult.已接单.ToString();
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
    }
}
