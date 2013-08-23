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
    public partial class FrmEquipmentRemainingProblemEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmEquipmentRemainingProblemEdit()
        {
            InitializeComponent();
        }

        private void FrmEquipmentRemainingProblemEdit_Load(object sender, EventArgs e)
        {

        }

        protected override void Loading()
        {
            //引用"设备未修复"的BLL文件，因为前面内容完全一样
            ctAccepter2.DataSource = BllEquipmentRepairFirst.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAccepter2.DisplayMember = "Name";

            ctAssist2.DataSource = BllEquipmentRepairFirst.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctAssist2.DisplayMember = "Name";

            ctResultConfirm.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "效果确认");
            ctResultConfirm.DisplayMember = "Name";

            ctFailureType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "故障分类");
            ctFailureType.DisplayMember = "Name";

            ctProductHandle.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "产品处理");
            ctProductHandle.DisplayMember = "Name";

            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            ctRemainingProblemHandleDate.Value = UserStatics.GetSqlServerDateTime();
        }

        protected override void Saving()
        {
            var obj = EquipmentMaintenance.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
            obj.Status = EquipmentResult.遗留问题修复.ToString();
            obj.Save();
            

        }

        protected override void DefineControlErrors()
        {

            if (ctRemainingProblem.Text == "") errorProvider.SetError(ctRemainingProblem, "遗留问题不能为空");
            else errorProvider.SetError(ctRemainingProblem, "");

            if (ctRemainingProblemResult.Text == "") errorProvider.SetError(ctRemainingProblemResult, "问题处理不能为空");
            else errorProvider.SetError(ctRemainingProblemResult, "");

        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
