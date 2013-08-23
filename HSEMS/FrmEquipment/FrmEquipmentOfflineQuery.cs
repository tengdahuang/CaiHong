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
    public partial class FrmEquipmentOfflineQuery : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentOfflineQuery()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmEquipmentOfflineQuery_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllEquipmentOffline.GetAllTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;

        }

        protected override string SetFilterString()
        {
            return "机台号 like '%" + tbFind.Text + "%' or 设备分类 like '%" + tbFind.Text + "%'";
        }
    }
}
