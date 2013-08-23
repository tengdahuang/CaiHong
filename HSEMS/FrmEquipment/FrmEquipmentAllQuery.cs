using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HSEMS.Bll;
using HSEMS.Dal;
using HSEMS.Common;
using XSolo.Common;

namespace HSEMS
{
    public partial class FrmEquipmentAllQuery : XSolo.BaseForm.FrmBTree
    {
        public FrmEquipmentAllQuery()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmEquipmentAllQuery_Load(object sender, EventArgs e)
        {
            //todo 窗体载入时，只载入最近一个月的内容


        }

        protected override void InitControls()
        {
            ctBegin.Value = DateTime.Now.AddMonths(-1);
            ctEnd.Value = DateTime.Now;

            ctAccepter.DataSource = BllEquipmentAllQuery.GetWhoRepair(UserStatics.OptrType);
            ctAccepter.DisplayMember = "Name";

            ctGroupMonitor.DataSource = BllEquipmentAllQuery.GetGroupMonitor(UserStatics.OptrType);
            ctGroupMonitor.DisplayMember = "Name";

            ctManageType.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "管理分类");
            ctManageType.DisplayMember = "Name";

            ctMonitor.DataSource = BllEquipmentAllQuery.GetRepairMonitor(UserStatics.OptrType);
            ctMonitor.DisplayMember = "Name";

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllEquipmentAllQuery.GetTableByTimeSpan(ctBegin.Value.ToShortDateString(),ctEnd.Value.AddDays(1).ToShortDateString(), UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.AutoGenerateColumns = false;
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["操作类型"].Visible = false;
            //baseDataGridView.Columns["Id"].Frozen = true;
            //baseDataGridView.Columns["报修日期"].Frozen = true;
            //baseDataGridView.Columns["测试系统"].Frozen = true;
            baseDataGridView.Columns["机台号"].Frozen = true;
        }

        protected override string SetFilterString()
        {
            StringBuilder mFilterString = new StringBuilder();
            mFilterString.Append( " 报修日期 >= '" + ctBegin.Value.ToShortDateString() + "' and 报修日期 <= '" +
                            ctEnd.Value.Date.AddDays(1).ToShortDateString() + "'") ;
            if (ctEquipmentNo.Text != "")
                mFilterString.Append(" and 机台号 = '" + ctEquipmentNo.Text + "'");
            if (ctManageType.Text != "")
                mFilterString.Append(" and 管理分类 like '%" + ctManageType.Text + "%'");
            if (ctAccepter.Text != "")
                mFilterString.Append(" and 接单人 like '%" + ctAccepter.Text + "%'");
            if (ctMonitor.Text != "")
                mFilterString.Append(" and 当班班长1 like '%" + ctMonitor.Text + "%'");
            //MessageBox.Show(mFilterString.ToString());
            return mFilterString.ToString();
            
        }

        private void ctEquipmentNo_Click(object sender, EventArgs e)
        {
            RaiseSearchWindow();
        }

        protected override void resetDataGridView()
        {
            TableForLoad = BllEquipmentAllQuery.GetTableByTimeSpan(ctBegin.Value.ToShortDateString(), ctEnd.Value.AddDays(1).ToShortDateString(), UserStatics.OptrType);
            reloadDataGridView();
        }

        private void RaiseSearchWindow()
        {
            FrmEquipmentInformation fei = new FrmEquipmentInformation(); ;
            fei.IsSelect = true;
            fei.SelectedValue = -1;
            fei.ShowDialog();
            if(fei.SelectedValue != -1)
            {
                //返回的SelectedValue,取出SelectedValue的EquipmentInformation
                EquipmentInformation ei = EquipmentInformation.FindById(fei.SelectedValue);
                ctEquipmentNo.Text = ei.EquipmentNo;
            }
            else
            {
                ctEquipmentNo.Text = "";
            }
            fei.Dispose();
        }
    }
}
