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

namespace HSEMS
{
    public partial class FrmTechnologicalEquipmentQuery : XSolo.BaseForm.FrmBTree
    {
        public FrmTechnologicalEquipmentQuery()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmTechnologicalEquipmentQuery_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllTechnologicalEquipment.GetTableTestOverrunAll();
            ctChange.Text = "在用";

        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            //if(UserStatics.OptrType == "Test")
            //{
            //    baseDataGridView.Columns["模具号"].Visible = false;
            //    baseDataGridView.Columns["产品类型"].Visible = false;
            //}

        }

        protected override void resetDataGridView()
        {
            TableForLoad = BllTechnologicalEquipment.GetTableTestOverrunAll();
            reloadDataGridView();
        }

        protected override string SetFilterString()
        {
            return "机台号 like '%" + tbFind.Text + "%' or 工装类型 like '%" + tbFind.Text + "%'";
        }

        override protected void DeleteCurrentRow()
        {
            int count = 0;

            foreach (DataGridViewRow row in baseDataGridView.SelectedRows)
            {
                BllTechnologicalEquipment.DelCell((long)row.Cells[0].Value);
                count++;
            }

            if (count == 0)
            {
                MessageBox.Show("没有删除任何记录！");
            }
            else
            {
                MessageBox.Show("已删除" + count + "条记录！");
            }

        }

        private void ctChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctChange.Text == "在用")
            {
                TableForLoad = BllTechnologicalEquipment.GetTableTestOverrunAll();
                reloadDataGridView();
                IsNoDoubleClick = false;
            }
            else if (ctChange.Text == "报废")
            {
                TableForLoad = BllTechnologicalEquipment.GetNoUseTable(UserStatics.OptrType);
                reloadDataGridView();
                IsNoDoubleClick = true;
            }
        }

        protected override void baseDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            if (ctChange.Text == "在用")
            {
                DataGridViewRow dgr = baseDataGridView.Rows[e.RowIndex];
                try
                {
                    //if (e.ColumnIndex == 3)//定位到第3列，如不定位到具体的哪列，则整行的颜色改变
                    //{
                    //}

                    if (dgr.Cells["工装类型"].Value.ToString().StartsWith("测试爪") &&
                        int.Parse(dgr.Cells["累计产量"].Value.ToString()) >= 9700000 &&
                        int.Parse(dgr.Cells["累计产量"].Value.ToString()) < 10100000
                        )//dgr.Cells["Column4"]为需要判断的列Name，而不是HeadText
                    {
                        e.CellStyle.BackColor = Color.HotPink;//将前景色设置为红色，即字体颜色设置为红色
                        //e.CellStyle.BackColor = Color.Green;//将背景色设置为绿色，即列的颜色设置为红色
                    }

                    if (dgr.Cells["工装类型"].Value.ToString().StartsWith("测试爪") &&
                            int.Parse(dgr.Cells["累计产量"].Value.ToString()) >= 10100000)
                    {
                        e.CellStyle.BackColor = Color.Red;//将前景色设置为红色，即字体颜色设置为红色

                    }

                    if (dgr.Cells["工装类型"].Value.ToString() == "成型刀" &&
                            int.Parse(dgr.Cells["累计产量"].Value.ToString()) >= 570000)
                    {
                        e.CellStyle.BackColor = Color.HotPink;//将前景色设置为红色，即字体颜色设置为红色

                    }

                    if (dgr.Cells["工装类型"].Value.ToString() == "成型刀" &&
                            int.Parse(dgr.Cells["实际产量"].Value.ToString()) >= 5700000)
                    {
                        e.CellStyle.BackColor = Color.Red;//将前景色设置为红色，即字体颜色设置为红色

                    }

                }
                catch
                {

                }
            }
        }
    }
}
