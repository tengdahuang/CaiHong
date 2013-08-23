using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Common;
using Lephone.Data;

namespace HSEMS
{
    public partial class FrmEquipmentClassifiedStatistic : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentClassifiedStatistic()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            lbFind.Visible = false;
            tbFind.Visible = false;
            btDisplayAll.Visible = false;
            btnFind.Visible = false;
        }

        private void FrmEquipmentClassifiedStatistic_Load(object sender, EventArgs e)
        {
        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctChoose.Text == "分类统计-维修-班组")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_GroupMonitor").Tables[0];
                reloadDataGridView();
            }
            if (ctChoose.Text == "分类统计-维修-个人")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_GroupPerson").Tables[0];
                reloadDataGridView();
            }
            if (ctChoose.Text == "分类统计-测试系统-月份")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_TestMonth").Tables[0];
                reloadDataGridView();
            }
            if (ctChoose.Text == "分类统计-测试系统-测试系统")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_TestSystem").Tables[0];
                reloadDataGridView();
            }
            if (ctChoose.Text == "分类统计-测试系统-故障分类")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_TestClass").Tables[0];
                reloadDataGridView();
            }
            if (ctChoose.Text == "分类统计-机械手-月份")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_OtherMonth").Tables[0];
                reloadDataGridView();
            }
            if (ctChoose.Text == "分类统计-机械手-机台号")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_OtherEquipmentNo").Tables[0];
                reloadDataGridView();
            }
            if (ctChoose.Text == "分类统计-机械手-故障分类")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentCS_Test_OtherClass").Tables[0];
                reloadDataGridView();
            }

            
        }
        
    }
}
