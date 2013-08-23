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
    public partial class FrmEquipmentVariationQuery : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentVariationQuery()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmEquipmentVariationQuery_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllEquipmentVariationQuery.GetAllTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;

        }

        protected override string SetFilterString()
        {
            return "机台号 like '%" + tbFind.Text + "%'";
        }
    }
}
