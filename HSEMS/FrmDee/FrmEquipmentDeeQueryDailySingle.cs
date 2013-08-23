using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Dal;
using HSEMS.Common;
using Lephone.Data;

namespace HSEMS
{
    public partial class FrmEquipmentDeeQueryDailySingle : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentDeeQueryDailySingle()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
            btDisplayAll.Visible = false;
        }

        private void FrmEquipmentDeeQueryDailySingle_Load(object sender, EventArgs e)
        {

        }

        protected override void InitControls()
        {
            ctBegin.Value = DateTime.Now.AddMonths(-1);
            ctEnd.Value = DateTime.Now;
        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            string s = "Select * from v_EquipmentDee_Test_Daily where 日期 between '" + ctBegin.Value.ToString() + "' and '" + ctEnd.Value.ToString() + "' order by 日期 desc";
            TableForLoad = DbEntry.Context.ExecuteDataset(s).Tables[0];
        }

        protected override void resetDataGridView()
        {
            string s = "Select * from v_EquipmentDee_Test_Daily where 日期 between '" + ctBegin.Value.ToString() + "' and '" + ctEnd.Value.ToString() + "' order by 日期 desc";
            TableForLoad = DbEntry.Context.ExecuteDataset(s).Tables[0];
            reloadDataGridView();
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.AutoGenerateColumns = false;
            baseDataGridView.Columns["Id"].Visible = false;
            baseDataGridView.Columns["Dee"].Frozen = true;

        }

        protected override string SetFilterString()
        {
            return "机台号 like '%" + tbFind.Text + "'";
        }

        //private void tbFind_Click(object sender, EventArgs e)
        //{
        //    RaiseSearchWindow();
        //}

        //private void RaiseSearchWindow()
        //{
        //    FrmEquipmentInformation fei = new FrmEquipmentInformation(); ;
        //    fei.IsSelect = true;
        //    fei.SelectedValue = -1;
        //    fei.ShowDialog();
        //    if (fei.SelectedValue != -1)
        //    {
        //        //返回的SelectedValue,取出SelectedValue的EquipmentInformation
        //        EquipmentInformation ei = EquipmentInformation.FindById(fei.SelectedValue);
        //        tbFind.Text = ei.EquipmentNo;
        //    }
        //    else
        //    {
        //        tbFind.Text = "";
        //    }
        //    fei.Dispose();
        //}
    }
}
