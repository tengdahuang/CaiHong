using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XSolo.ModuleActions.BLL;

namespace XSolo.ModuleActions
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
            DataTable dataTable = BllACLModule.GetActions(long.Parse(s));
            CreateActionButtons();

            this.AsmName = "XSolo.ModuleActions";
            IdNameInTable = "Id";
            FormTreeRootName = "所有窗体类型";
            IsTree = true;

            this.baseTreeView.Nodes.Clear();

            reloadDataGridView();
            this.CreateTree(ref TableForLoad);
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["父窗体"].Visible = false;
        }

        protected override void reloadDataGridView()
        {
            TableForLoad = BllACLModule.GetMainModuleDataTable();
            baseBindingSource.DataSource = TableForLoad;
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
