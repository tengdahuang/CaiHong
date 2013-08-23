using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmAttendanceRateEntry : XSolo.BaseForm.FrmBTree
    {
        public FrmAttendanceRateEntry()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;
        }

        private void FrmAttendanceRateEntry_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllAttendanceRate.GetOneWeek(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["用户类型"].Visible = false;

        }

        override protected void DeleteCurrentRow()
        {
            int count = 0;

            foreach (DataGridViewRow row in baseDataGridView.SelectedRows)
            {
                BllAttendanceRate.DelCell((long)row.Cells[0].Value);
                count++;
            }

            if (count == 0)
            {
                MessageBox.Show("没有删除任何记录！");
            }
            else
            {
                MessageBox.Show("已删除" + count + "条记录！");
            }
        }

        protected override void resetDataGridView()
        {

            TableForLoad = BllAttendanceRate.GetOneWeek(UserStatics.OptrType);
            reloadDataGridView();
        }
    }
}
