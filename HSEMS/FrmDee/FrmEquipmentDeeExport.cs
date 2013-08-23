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
    public partial class FrmEquipmentDeeExport : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentDeeExport()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            lbFind.Visible = false;
            tbFind.Visible = false;
            btDisplayAll.Visible = false;
            btnFind.Visible = false;
        }

        private void FrmEquipmentDeeExport_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);

        }

        private void ctChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctChoose.Text == "华汕机台")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_ExportF").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
            if (ctChoose.Text == "NXP机台")
            {
                TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_ExportN").Tables[0];
                reloadDataGridView();
                baseDataGridView.Columns["Id"].Visible = false;

            }
        }
    }
}
