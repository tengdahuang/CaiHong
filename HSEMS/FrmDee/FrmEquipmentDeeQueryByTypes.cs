using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lephone.Data;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmEquipmentDeeQueryByTypes : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentDeeQueryByTypes()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            lbFind.Visible = false;
            tbFind.Visible = false;
            btDisplayAll.Visible = false;
            btnFind.Visible = false;
        }



        private void FrmEquipmentDeeQueryByTypes_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);

        }

        private void ctChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctChoose.Text == "大功率合计")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_MonHighPower").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Dee"].Frozen = true;
            }
            if (ctChoose.Text == "分类统计")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_MonStatisticalClass").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Dee"].Frozen = true;
            }
        }

    }
}
