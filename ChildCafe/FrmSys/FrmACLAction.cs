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
    public partial class FrmACLAction : XSolo.BaseForm.FrmBTree
    {
        public FrmACLAction()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;
        }

        private void FrmACLAction_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllACLAction.GetTable();
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns["Id"].Visible = false;

        }

        protected override void DeleteCurrentRow()
        {
            if (baseDataGridView.SelectedCells[1].Value.ToString() == "root")
                MessageBox.Show("root用户不能删除！！");
            else
                BllACLAction.DelCell(DeletingRowId);
        }
    }
}
