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
    public partial class FrmACLUser : XSolo.BaseForm.FrmBTree
    {
        public FrmACLUser()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;

        }

        private void FrmACLUser_Load(object sender, EventArgs e)
        {
            string s = this.Tag.ToString().Split('.')[1];
            DataTable dataTable = BllACLUser.GetUserActions(long.Parse(s));
            CreateActionButtons(ref dataTable);

            AsmName = "TDAccessControl";
            SItemId = "Id";

            reloadDataGridView();
            baseDataGridView.Columns[SItemId].Visible = false;

        }

        protected override void reloadDataGridView()
        {
            myTable = BllACLUser.GetMainOptrDataTable();
            baseBindingSource.DataSource = myTable;
            baseDataGridView.DataSource = baseBindingSource;
        }

        override protected void DeleteCurrentRow()
        {
            if (baseDataGridView.SelectedCells[1].Value.ToString() == "root")
                MessageBox.Show("root用户不能删除！！");
            else 
                BllACLUser.DelCell((long)baseDataGridView.SelectedCells[0].Value);
        }

        protected override void SetOperation()
        {
            FrmACLUserModules frmAclUserModules = new FrmACLUserModules();
            frmAclUserModules.OptrId = long.Parse(baseDataGridView.SelectedCells[0].Value.ToString());
            frmAclUserModules.ShowDialog();
        }
    }
}
