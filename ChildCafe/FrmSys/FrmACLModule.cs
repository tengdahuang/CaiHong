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
    public partial class FrmACLModule : XSolo.BaseForm.FrmBTree
    {
        public FrmACLModule()
        {
            InitializeComponent();
            panelFind.Visible = false;
        }

        private void FrmACLModule_Load(object sender, EventArgs e)
        {

        }

        protected override void SetDataGridViewColumns()
        {
            //baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["上一级"].Visible = false;

        }

        protected override void InitData()
        {
            IsTree = true;
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllACLModule.GetTable();
        }


        override protected void DeleteCurrentRow()
        {
            BllACLModule.DelCell(DeletingRowId);
        }

        protected override void SetOperation()
        {
            FrmACLModuleAction frmAclModuleAction = new FrmACLModuleAction();
            if (baseDataGridView.RowCount > 0)
            {
                frmAclModuleAction.ModuleId = long.Parse(baseDataGridView.SelectedCells[0].Value.ToString());
                frmAclModuleAction.ShowDialog();
                frmAclModuleAction.Dispose();
            }
            else
            {
                frmAclModuleAction.Dispose();
            }

        }

    }

}
