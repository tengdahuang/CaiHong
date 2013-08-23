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
    public partial class FrmEquipmentInformation : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentInformation()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        protected override void InitData()
        {
            lbFind.Text = "输入机台号任意尾数筛选";
            ActionTable = UserStatics.GetUserActions(ModuleId);
            if(IsSelect == true)
                TableForLoad = BllEquipmentInformation.GetPartTable(UserStatics.OptrType);
            else
            TableForLoad = BllEquipmentInformation.GetTable(UserStatics.OptrType);
        }

        override protected void DeleteCurrentRow()
        {
            BllEquipmentInformation.DelCell((long)baseDataGridView.SelectedCells[0].Value);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["操作类型"].Visible = false;

        }

        protected override string SetFilterString()
        {
            return "机台号 like '%" + tbFind.Text + "'";
        }

        private void FrmEquipmentInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
