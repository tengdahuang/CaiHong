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
    public partial class FrmTechnologicalEquipmentSharpeningEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmTechnologicalEquipmentSharpeningEdit()
        {
            InitializeComponent();
            toolStripButtonSave.Text = "磨刀(&S)";
        }

        private void FrmTechnologicalEquipmentSharpeningEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {

            var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            ctUseCount.Value = BllTechnologicalEquipment.GetUseAmount(long.Parse(ItemID));
            ctUninstallDate.Value = UserStatics.GetSqlServerDateTime();


        }

        protected override void Saving()
        {

            ////如果使用寿命 != 0 并且 工装处理 = 备用，则原始寿命= 原始寿命+使用寿命
            //if (ctUseCount.Value != 0 && (ctTeHandle.Text == "备用" || ctTeHandle.Text == "报废"))
            //{
            //    var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
            //    FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            //    obj.OptrType = UserStatics.OptrType;
            //    obj.ElderCount = obj.UseCount + obj.ElderCount;
            //    obj.UseCount = 0;
            //    obj.Save();
            //}
            //else
            //{

            //工装状态+1
            ctTechnologicalEquipmentStatus.Value = ctTechnologicalEquipmentStatus.Value + 1;
            ctUseCount.Value = 0;
            //原始寿命必须清零
            ctElderCount.Value = 0;
            var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            obj.OptrType = UserStatics.OptrType;
            obj.Save();
            //}

        }

        protected override void AfterSave()
        {
            ClearControls();
        }

    }
}
