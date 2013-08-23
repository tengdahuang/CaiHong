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
    public partial class FrmTechnologicalEquipmentOverrunEdit : XSolo.BaseForm.FrmAddEdit
    {
        private string OwnTE;
        private string OwnWhoInstalled;

        public FrmTechnologicalEquipmentOverrunEdit()
        {
            InitializeComponent();
        }

        private void FrmTechnologicalEquipmentOverrunEdit_Load(object sender, EventArgs e)
        {

        }

        private void ctEquipmentNo_Click(object sender, EventArgs e)
        {
            RaiseSearchWindow();
        }

        private void ctEquipmentNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                RaiseSearchWindow();
            }
        }

        private void RaiseSearchWindow()
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

        protected override void Loading()
        {
            if (UserStatics.OptrType == "Test")
            {
                ctModeNo.Enabled = false;
                ctProductType.Enabled = false;
            }

            ctProductType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "适应产品");
            ctProductType.DisplayMember = "Name";

            ctWhoUninstalled.DataSource = BllTechnologicalEquipment.GetWhoRepairByWorkShop(UserStatics.OptrType, UserStatics.WorkShop);
            ctWhoUninstalled.DisplayMember = "Name";

            ctTeHandle.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工装处理");
            ctTeHandle.DisplayMember = "Name";

            ctSupplier.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "供应商");
            ctSupplier.DisplayMember = "Name";

            var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);

            ctUninstallDate.Value = UserStatics.GetSqlServerDateTime();
            OwnTE = ctTeNo.Text;
            OwnWhoInstalled = ctWhoInstalled.Text;
        }

        protected override void Saving()
        {
            //将原先的工装，改为报废，并保存时.保存一份旧档.
            //a.窗口打开时，读取工装编号和安装人，放在窗体变量。先保存旧档。
            //b.新建一个新档，初始化后保存
            //不为报废，保存时，保存动作不变
            if (ctTeHandle.Text == "报废")
            {
                var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.TeNo = OwnTE;
                obj.WhoInstalled = OwnWhoInstalled;
                obj.Save();
                
                var obj2 = TechnologicalEquipment.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj2, tabPage1);
                obj2.OptrType = UserStatics.OptrType;
                obj2.InstallDate = DateTime.Now;
                obj2.UninstallDate = Convert.ToDateTime("1900-01-01 00:00:00");
                obj2.UninstallReason = "";
                obj2.WhoUninstalled = "";
                obj2.UseCount = 0;
                obj2.TechnologicalEquipmentStatus = 0;
                obj2.TeHandle = "在用";
                obj2.Save();

            }
            else
            {
                var obj = TechnologicalEquipment.FindById(long.Parse(ItemID));
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
                if (ctEquipmentNo.Text == "") errorProvider.SetError(ctEquipmentNo, "机台号不能为空");
                else errorProvider.SetError(ctEquipmentNo, "");

                if (ctTeNo.Text == OwnTE) errorProvider.SetError(ctTeNo, "工装编号没有修改，不能报废");
                else errorProvider.SetError(ctEquipmentNo, "");


                if (ctUpperLimitCount.Value > 1000000 && ctTechnologicalEquipmentType.Text == "成型刀") errorProvider.SetError(ctUpperLimitCount, "成型刀寿命上限超过100万，请确认输入是否正确");
                else errorProvider.SetError(ctUpperLimitCount, "");
            }


        }

        private void ctTechnologicalEquipmentType_Leave(object sender, EventArgs e)
        {
            if (ctTechnologicalEquipmentType.Text == "成型刀" || ctTechnologicalEquipmentType.Text == "测试爪")
            {
                ctLowerLimitCount.Value = 9800000;
                ctUpperLimitCount.Value = 10100000;
            }
        }

        private void ctTeHandle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ctTeHandle.Text == "报废")
            {
                decimal v = BllTechnologicalEquipment.GetUseAmount(long.Parse(ItemID));
                ctUseCount.Value = v;
            }
        }

    }
}
