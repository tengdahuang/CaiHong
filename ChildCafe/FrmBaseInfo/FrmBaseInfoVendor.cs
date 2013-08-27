using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoVendor : XSolo.BaseForm.FrmBTree
    {
        public FrmBaseInfoVendor()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmBaseInfoVendor_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllBaseInfoMember.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["用户类型"].Visible = false;

        }

        override protected void DeleteCurrentRow(DataGridViewRow row)
        {
            BllBaseInfoMember.DelCell((long)row.Cells[0].Value);
        }


        protected override void resetDataGridView()
        {
            TableForLoad = BllBaseInfoVendor.GetTable(UserStatics.OptrType);
            reloadDataGridView();
        }

        protected override string SetFilterString()
        {
            return "简拼 like '%" + tbFind.Text + "%'";
        }


    }
}
