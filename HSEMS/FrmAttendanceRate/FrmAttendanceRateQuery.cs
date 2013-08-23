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
    public partial class FrmAttendanceRateQuery : XSolo.BaseForm.FrmBTree
    {
        public FrmAttendanceRateQuery()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            lbFind.Visible = false;
            tbFind.Visible = false;
            btDisplayAll.Visible = false;
            btnFind.Visible = false;
        }

        private void FrmAttendanceRateQuery_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);

        }

        private void ctChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctChoose.Text == "出勤产量-每日-测试效率")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_AttendanceRate_Test_DailyTest").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "出勤产量-每日-包装效率")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_AttendanceRate_Test_DailyPackage").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "出勤产量-每日-部门效率")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_AttendanceRate_Test_DailyDepartment").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "出勤产量-月度-测试效率")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_AttendanceRate_Test_MonthlyTest").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "出勤产量-月度-包装效率")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_AttendanceRate_Test_MonthlyPackage").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "出勤产量-月度-部门效率")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_AttendanceRate_Test_MonthlyDepartment").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
        }
    }
}
