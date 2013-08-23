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
    public partial class FrmMainDictType : XSolo.BaseForm.FrmBTree
    {
        public FrmMainDictType()
        {
            InitializeComponent(); 
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;
        }

        private void FrmMainDictType_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllMainDictType.GetTable(UserStatics.OptrType);
        }

        override protected void DeleteCurrentRow()
        {
            int count = 0;

            foreach (DataGridViewRow row in baseDataGridView.SelectedRows)
            {
                BllMainDictType.DelCell((long)row.Cells[0].Value);
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
    }
}
