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
    public partial class FrmEquipmentVariationHandle2Edit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentVariationHandle2Edit()
        {
            IsAdd = false;
            InitializeComponent();
        }

        private void FrmEquipmentVariationHandle2Edit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {

            ctAccepter2.DataSource = BllEquipmentVariationHandle2.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAccepter2.DisplayMember = "Name";

            ctResultConfirm.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "变更效果确认");
            ctResultConfirm.DisplayMember = "Name";

            ctFinishDate2.Value = DateTime.Now;
            var obj = EquipmentVariation.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);

        }

        protected override void Saving()
        {
            var obj = EquipmentVariation.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            TimeSpan ts = ctFinishDate2.Value - (DateTime)obj.FinishDate1;
            obj.VariationTakes2 = Math.Ceiling(ts.TotalMinutes);

            obj.Status = VariationResult.已完成.ToString();
            obj.Save();


        }

        protected override void DefineControlErrors()
        {

            if (ctResultConfirm.Text == "" || ctResultConfirm.Text == VariationResult.未完成.ToString()) errorProvider.SetError(ctResultConfirm, "变更效果确认不能为未完成或空");
            else errorProvider.SetError(ctResultConfirm, "");

            if (ctVariationContent2.Text == "") errorProvider.SetError(ctVariationContent2, "最后处理不能为空");
            else errorProvider.SetError(ctVariationContent2, "");

            if (ctAccepter2.Text == "") errorProvider.SetError(ctAccepter2, "处理者2不能为空");
            else errorProvider.SetError(ctAccepter2, "");

        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
