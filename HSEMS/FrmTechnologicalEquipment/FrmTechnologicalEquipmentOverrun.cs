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
    public partial class FrmTechnologicalEquipmentOverrun : XSolo.BaseForm.FrmBTree
    {
        public FrmTechnologicalEquipmentOverrun()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmTechnologicalEquipmentOverrun_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            lbFind.Text = "可以按机台号和工装编号模糊查找";
            ActionTable = UserStatics.GetUserActions(ModuleId);
            if (UserStatics.OptrType == "Test")
            {
                TableForLoad = BllTechnologicalEquipment.GetTableTestOverrun();
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

        protected override void baseDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

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
