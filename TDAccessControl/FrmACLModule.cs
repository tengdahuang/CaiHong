using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TDAccessControl.BLL;

namespace TDAccessControl
{
    public partial class FrmACLModule : XSolo.BaseForm.FrmBTree
    {
        public FrmACLModule()
        {
            InitializeComponent();

        }

        private void FrmACLModule_Load(object sender, EventArgs e)
        {
            string s = Tag.ToString().Split('.')[1];
            DataTable dataTable = BllACLAction.GetActions();
            CreateActionButtons(ref dataTable);

            this.AsmName = "TDAccessControl";
            SItemId = "Id";
            FormTreeRootName = "所有窗体类型";
            IsTree = true;

            this.baseTreeView.Nodes.Clear();

            reloadDataGridView();
            this.CreateTree(ref myTable);
            baseDataGridView.Columns[SItemId].Visible = false;
            baseDataGridView.Columns["父窗体"].Visible = false;
        }

        protected override void reloadDataGridView()
        {
            myTable = BllACLModule.GetMainModuleDataTable();
            baseBindingSource.DataSource = myTable;
            baseDataGridView.DataSource = baseBindingSource;
        }

        override protected void DeleteCurrentRow()
        {
                BllACLModule.DelCell((long) baseDataGridView.SelectedCells[0].Value);
        }

        protected override void SetOperation()
        {
            FrmACLModuleAction frmAclModuleAction = new FrmACLModuleAction();
            frmAclModuleAction.ModuleId = long.Parse(baseDataGridView.SelectedCells[0].Value.ToString());
            frmAclModuleAction.ShowDialog();
        }

    }

}
