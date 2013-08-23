using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;
using ChildCafe.Dal;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoMember : XSolo.BaseForm.FrmBTree
    {
        public FrmBaseInfoMember()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;

        }

        private void FrmBaseInfoMember_Load(object sender, EventArgs e)
        {


        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllBaseInfoMember.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["用户类型"].Visible = false;

        }

        protected override void SetImportOptration()
        {
            try
            {
                ImportToAccess();
                MessageBox.Show("导入成功！");

            }
            catch (Exception ex)
            {
                MessageBox.Show("导入有问题，请注意删除第一行中文标题，日期精确到秒，并且数值类型如没有必须用0代替！有问题请联系电脑室\n" + ex);
            }
        }

        protected override void SetRechargeOptration()
        {
            FrmBaseInfoMemberRechargeEdit frmBaseInfoMemberRechargeEdit = new FrmBaseInfoMemberRechargeEdit();
            if (baseDataGridView.RowCount > 0)
            {
                frmBaseInfoMemberRechargeEdit.IsAdd = true;
                frmBaseInfoMemberRechargeEdit.MemberId = long.Parse(baseDataGridView.SelectedCells[0].Value.ToString());
                frmBaseInfoMemberRechargeEdit.ShowDialog();
                frmBaseInfoMemberRechargeEdit.Dispose();
            }
            else
            {
                MessageBox.Show("请选择一个会员");
                frmBaseInfoMemberRechargeEdit.Dispose();
            }

        }

        override protected void DeleteCurrentRow()
        {
            int count = 0;

            foreach (DataGridViewRow row in baseDataGridView.SelectedRows)
            {
                BllBaseInfoMember.DelCell((long)row.Cells[0].Value);
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

        public void ImportToAccess()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + ofd.FileName + ";" +
                                 "Extended Properties=Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                strExcel = string.Format("select * from [{0}$]", "Sheet1"); //Sheet1为excel中工作薄
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds, "Sheet1");
                DataTable dt = ds.Tables["Sheet1"];

                Encoding gb2312 = Encoding.GetEncoding("GB2312");
                for (int iRow = 1; iRow < dt.Rows.Count; iRow++)
                {
                    BaseInfoMember bifm = BaseInfoMember.New;
                    bifm.JoinedDate = (DateTime)dt.Rows[iRow][0];
                    bifm.CardNumber = dt.Rows[iRow][1].ToString();
                    bifm.Name = dt.Rows[iRow][2].ToString();
                    bifm.PinYin = PinYinTransfer.GetInitials(bifm.Name, gb2312);
                    bifm.Password = dt.Rows[iRow][4].ToString();
                    bifm.Birth = (DateTime)dt.Rows[iRow][5];
                    bifm.Mobile = dt.Rows[iRow][6].ToString();
                    bifm.Phone = dt.Rows[iRow][7].ToString();
                    bifm.DiscountRate = decimal.Parse(dt.Rows[iRow][8].ToString());
                    bifm.RemainingSum = decimal.Parse(dt.Rows[iRow][9].ToString());
                    bifm.TotalBonusPoint = decimal.Parse(dt.Rows[iRow][10].ToString());
                    bifm.Frequency = decimal.Parse(dt.Rows[iRow][11].ToString());
                    bifm.TotalSpending = decimal.Parse(dt.Rows[iRow][12].ToString());
                    bifm.Description = dt.Rows[iRow][13].ToString();
                    bifm.SavedOn = DateTime.Now;
                    bifm.OptrType = UserStatics.OptrType;
                    bifm.Save();

                }
            }
        }

        protected override void resetDataGridView()
        {
            TableForLoad = BllBaseInfoMember.GetTable(UserStatics.OptrType);
            reloadDataGridView();
        }

        protected override string SetFilterString()
        {
            return "简拼 like '%" + tbFind.Text + "%'";
        }
    }
}
