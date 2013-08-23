using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Common;
using Lephone.Data;
using System.Data.SqlClient;
using Lephone.Data.SqlEntry;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmEquipmentDeeQuery : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentDeeQuery()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmEquipmentDeeQuery_Load(object sender, EventArgs e)
        {

        }

        protected override void InitControls()
        {
            ctBegin.Value = DateTime.Now.AddMonths(-1);
            ctEnd.Value = DateTime.Now;
        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllEquipmentDee.GetTableByTimeSpan(ctBegin.Value.ToString(), ctEnd.Value.ToString(), UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["用户类型"].Visible = false;
            baseDataGridView.Columns["模具号"].Visible = false;

        }

        protected override void SetImportOptration()
        {
            try
            {
                ExcelToSqlServer.ImportToSQL("EquipmentDee");
            }
            catch (Exception)
            {
                MessageBox.Show("导入有问题，请注意删除第一行中文标题，日期精确到秒，并且数值类型如没有必须用0代替！有问题请联系电脑室");
                throw;
            }
            

        }

        override protected void DeleteCurrentRow()
        {
            int count = 0;

            foreach (DataGridViewRow row in baseDataGridView.SelectedRows)
            {
                BllEquipmentDee.DelCell((long)row.Cells[0].Value);
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

            TableForLoad = BllEquipmentDee.GetTableByTimeSpan(ctBegin.Value.AddDays(-1).ToString(), ctEnd.Value.ToString(), UserStatics.OptrType);
            reloadDataGridView();
        }

        protected override string SetFilterString()
        {
            return "机台号 like '%" + tbFind.Text + "%'";
        }

    }
}
