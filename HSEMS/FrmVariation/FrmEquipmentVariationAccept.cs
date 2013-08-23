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
    public partial class FrmEquipmentVariationAccept : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentVariationAccept()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;
        }

        private void FrmEquipmentVariationAccept_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllEquipmentVariationAccept.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["OptrType"].Visible = false;
            baseDataGridView.Columns["WaitingTakes"].Visible = false;
            baseDataGridView.Columns["VariationTakes1"].Visible = false;
            baseDataGridView.Columns["VariationTakes2"].Visible = false;
        }
    }
}
