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
    public partial class FrmTechnologicalEquipmentSharpening : XSolo.BaseForm.FrmBTree
    {
        public FrmTechnologicalEquipmentSharpening()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmTechnologicalEquipmentSharpening_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            lbFind.Text = "可以按机台号和工装编号模糊查找";
            ActionTable = UserStatics.GetUserActions(ModuleId);
            if (UserStatics.OptrType == "Test")
            {
                TableForLoad = BllTechnologicalEquipment.GetTableTestSharpening();
            }
        }


        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;

        }

        protected override string SetFilterString()
        {
            return "机台号 like '" + tbFind.Text + "%' or 工装编号 like '%" + tbFind.Text + "%'";
        }
    }
}
