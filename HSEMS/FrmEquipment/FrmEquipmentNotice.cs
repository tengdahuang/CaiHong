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
using log4net;
using log4net.Config;
using Lephone.Data;

namespace HSEMS
{
    public partial class FrmEquipmentNotice : XSolo.BaseForm.FrmAddEdit
    {
        //private static readonly ILog log = LogManager.GetLogger(typeof(FrmEquipmentNotice));

        public FrmEquipmentNotice()
        {
            IsAdd = true;
            InitializeComponent();
        }

        private void FrmEquipmentNotice_Load(object sender, EventArgs e)
        {
            //BasicConfigurator.Configure();
            //log.Info("Entering application.");
        }

        protected override void Loading()
        {

            if (UserStatics.OptrType == "Test")
            {
                ctProcess.Enabled = false;
                ctModeNo.Enabled = false;

                ctTestSystem.DataSource = BllEquipmentNotice.GetEquipmentType(UserStatics.OptrType, "测试系统");
                ctTestSystem.DisplayMember = "EquipmentNo";

                ctTester.DataSource = BllEquipmentNotice.GetEquipmentType(UserStatics.OptrType, "测试仪");
                ctTester.DisplayMember = "EquipmentNo";

                //机台号每个工序都会不同
                ctEquipmentNo.DataSource = BllEquipmentNotice.GetEquipmentNoByProcess(UserStatics.OptrType, "测试");
                ctEquipmentNo.DisplayMember = "EquipmentNo";

                ctWhoNotice.DataSource = BllEquipmentNotice.GetWhoNoticeByProcess(UserStatics.OptrType, UserStatics.WorkShop);
                ctWhoNotice.DisplayMember = "Name";
            }

            if (UserStatics.OptrType == "Package" || UserStatics.OptrType == "Assembly")
            {
                ctTestSystem.Enabled = false;
                ctTester.Enabled = false;


                ctWhoNotice.DataSource = BllEquipmentNotice.GetWhoNoticeByProcess(UserStatics.OptrType, UserStatics.WorkShop);
                ctWhoNotice.DisplayMember = "Name";
            }

            ctProcess.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "工序");
            ctProcess.DisplayMember = "Name";

            ctManagementType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "管理分类");
            ctManagementType.DisplayMember = "Name";

            ctFailurePhenomenon.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "故障现象");
            ctFailurePhenomenon.DisplayMember = "Name";



            ctNoticeDate.Value = UserStatics.GetSqlServerDateTime();
        }


        private void ctProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserStatics.OptrType == "Package" || UserStatics.OptrType == "Assembly")
            {
                //机台号每个工序都会不同
                ctEquipmentNo.DataSource = BllEquipmentNotice.GetEquipmentNoByProcess(UserStatics.OptrType, ctProcess.Text);
                ctEquipmentNo.DisplayMember = "EquipmentNo";

            }
        }

        protected override void Saving()
        {
            if (IsAdd)
            {
                ctNoticeDate.Value = UserStatics.GetSqlServerDateTime();
                var obj = EquipmentMaintenance.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                obj.OptrType = UserStatics.OptrType;
                obj.Status = EquipmentResult.已报修.ToString();
                obj.WaitingTakes = 0;
                obj.RepairingTakes1 = 0;
                obj.RepairingTakes2 = 0;
                obj.IsIsolated = false;
                if (UserStatics.OptrType == "Test")
                {
                    obj.Process = "测试";
                }

                obj.Save();
            }

        }

        protected override void AfterSave()
        {
            ClearControls();
        }

        protected override void DefineControlErrors()
        {
            if (ctEquipmentNo.Text == "") errorProvider.SetError(ctEquipmentNo, "机台号不能为空");
            else errorProvider.SetError(ctEquipmentNo, "");
            if (ctLotNo.Text == "") errorProvider.SetError(ctLotNo, "批号不能为空");
            else errorProvider.SetError(ctLotNo, "");
            if (ctProductClass.Text == "") errorProvider.SetError(ctProductClass, "品种不能为空");
            else errorProvider.SetError(ctProductClass, "");
            if (ctWhoNotice.Text == "") errorProvider.SetError(ctWhoNotice, "报修人不能为空");
            else errorProvider.SetError(ctWhoNotice, "");
            if (ctManagementType.Text == "") errorProvider.SetError(ctManagementType, "管理分类不能为空");
            else errorProvider.SetError(ctManagementType, "");
            if (ctFailurePhenomenon.Text == "") errorProvider.SetError(ctFailurePhenomenon, "故障现象不能为空");
            else errorProvider.SetError(ctFailurePhenomenon, "");
        }

        private void ctEquipmentNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (UserStatics.OptrType == "Package" || UserStatics.OptrType == "Assembly")
            {

                EquipmentInformation ei = (EquipmentInformation)ctEquipmentNo.SelectedItem;
                if (ei.ModeNo != null)
                {

                    ctModeNo.Text = ei.ModeNo.ToString();
                }
            }
        }


    }
}
