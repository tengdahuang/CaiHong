using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Dal;
using Lephone.Data;
using HSEMS.Common;

namespace HSEMS
{
    public partial class FrmEquipmentDeeQueryBySingle : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentDeeQueryBySingle()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            btDisplayAll.Visible = false;
        }

        private void FrmEquipmentDeeQueryBySingle_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_SingleMonth").Tables[0];
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.AutoGenerateColumns = false;
            baseDataGridView.Columns["Id"].Visible = false;
            baseDataGridView.Columns["Dee"].Frozen = true;

        }

        protected override string SetFilterString()
        {
            return "年 = '" + tbYear.Text + "' and 月 = '" + tbMonth.Text + "'";
                    
        }

        private void tbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void tbMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

    }
}
