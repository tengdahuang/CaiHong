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
    public partial class FrmACLAction : XSolo.BaseForm.FrmBTree
    {
        public FrmACLAction()
        {
            InitializeComponent();

        }

        private void FrmACLAction_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            string s = Tag.ToString().Split('.')[1];
            DataTable dataTable = BllACLAction.GetActions(long.Parse(s));
            CreateActionButtons();

            this.AsmName = "XSolo.ModuleActions";
            IdNameInTable = "Id";
            reloadDataGridView();
            baseDataGridView.Columns["Id"].Visible = false;

        }

        protected override void reloadDataGridView()
        {
            var actionTable = BllACLAction.GetActions();
            baseBindingSource.DataSource = actionTable;
            baseDataGridView.DataSource = baseBindingSource;
        }

        override protected void DeleteCurrentRow()
        {
            if (baseDataGridView.SelectedCells[1].Value.ToString() == "root")
                MessageBox.Show("root用户不能删除！！");
            else
                BllACLAction.DelCell((long)baseDataGridView.SelectedCells[0].Value);
        }
    }
}
