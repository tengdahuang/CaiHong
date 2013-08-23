using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmHrPersonnelFile : XSolo.BaseForm.FrmBTree
    {
        public FrmHrPersonnelFile()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        protected override void InitData()
        {
            lbFind.Text = "可以按姓名和卡号模糊查找";
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllHrPersonnelFile.GetTable(UserStatics.OptrType);
        }

        override protected void DeleteCurrentRow()
        {
            BllHrPersonnelFile.DelCell((long)baseDataGridView.SelectedCells[0].Value);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["操作类型"].Visible = false;

        }

        protected override string SetFilterString()
        {
            return "姓名 like '" + tbFind.Text + "%' or 卡号 like '" + tbFind.Text + "%'";
        }

    }
}
