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
    public partial class FrmMainDict : XSolo.BaseForm.FrmBTree
    {
        public FrmMainDict()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            lbFind.Visible = false;
            tbFind.Visible = false;
            btDisplayAll.Visible = false;
            btnFind.Visible = false;

        }

        private void FrmMainDict_Load(object sender, EventArgs e)
        {

        }

        protected override void InitControls()
        {
            cbDictType.DataSource = BllMainDict.GetDictType(UserStatics.OptrType);
            cbDictType.DisplayMember = "Name";
            cbDictType.ValueMember = "Id";
        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllMainDict.GetTable(UserStatics.OptrName, UserStatics.OptrType, cbDictType.SelectedText);
        }

        protected override void resetDataGridView()
        {
            TableForLoad = BllMainDict.GetTable(UserStatics.OptrName, UserStatics.OptrType, cbDictType.Text);
            base.resetDataGridView();
        }


        override protected void DeleteCurrentRow()
        {
                BllMainDict.DelCell(DeletingRowId);
        }


        private void cbDictType_TextChanged(object sender, EventArgs e)
        {
            TableForLoad = BllMainDict.GetTable(UserStatics.OptrName, UserStatics.OptrType, cbDictType.Text);
            reloadDataGridView();

        }
    }
}
