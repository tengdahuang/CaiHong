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
    public partial class FrmEquipmentDeeOutputTotal : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentDeeOutputTotal()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            btDisplayAll.Visible = false;
            btnFind.Visible = false;
        }

        private void FrmEquipmentDeeOutputTotal_Load(object sender, EventArgs e)
        {
            lbFind.Text = "请输入长年份格式或短年份格式进行筛选";
        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = DbEntry.Context.ExecuteDataset("Select * from v_EquipmentDee_Test_OutputTotal").Tables[0];
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns["Id"].Visible = false;
        }

        protected override string SetFilterString()
        {
            return "年份 like '%" + tbFind.Text + "'";
        }
    }
}
