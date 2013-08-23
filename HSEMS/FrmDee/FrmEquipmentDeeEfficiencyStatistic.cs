using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lephone.Data;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmEquipmentDeeEfficiencyStatistic : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentDeeEfficiencyStatistic()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            btDisplayAll.Visible = false;
            btnFind.Visible = false;
        }

        private void FrmEquipmentDeeEfficiencyStatistic_Load(object sender, EventArgs e)
        {
            lbFind.Text = "请输入长年份格式或短年份格式进行筛选";
        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);

        }



        protected override string SetFilterString()
        {
            return "年份 like '%" + tbFind.Text + "'";
        }

        private void ctChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctChoose.Text == "按班组统计")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_MonManagementGroup").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "按组长统计")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_MonGroupMonitor").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "按操作工统计")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_MonPerson").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "按维修班统计")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_MonRepairMonitor").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
        }

    }
}
