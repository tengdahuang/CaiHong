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
    public partial class FrmEquipmentAccept : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentAccept()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            panelFind.Visible = false;
        }

        private void FrmEquipmentAccept_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllEquipmentAccept.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["OptrType"].Visible = false;
            baseDataGridView.Columns["WaitingTakes"].Visible = false;
            baseDataGridView.Columns["RepairingTakes1"].Visible = false;
            baseDataGridView.Columns["RepairingTakes2"].Visible = false;
            if (UserStatics.OptrType == "Test")
            {
                baseDataGridView.Columns["工序"].Visible = false;
                baseDataGridView.Columns["模具号"].Visible = false;
            }

            if (UserStatics.OptrType == "Package" || UserStatics.OptrType == "Assembly")
            {
                baseDataGridView.Columns["测试系统"].Visible = false;
                baseDataGridView.Columns["测试仪"].Visible = false;
            }
        }
    }
}
