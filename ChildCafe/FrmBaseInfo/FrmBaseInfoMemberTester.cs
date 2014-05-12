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
    public partial class FrmBaseInfoMemberTester : XSolo.BaseForm.FrmBTree
    {
        public FrmBaseInfoMemberTester()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmBaseInfoMemberTester_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllBaseInfoMemberTester.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns["状态"].Visible = false;
            baseDataGridView.Columns["简拼"].Visible = false;

        }

        protected override void SetImportOptration()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DataSet ds = new DataSet();
                    string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + ofd.FileName + ";" +
                                     "Extended Properties='Excel 8.0;HDR=yes;IMEX=1'";
                    OleDbConnection conn = new OleDbConnection(strConn);
                    conn.Open();
                    string strExcel = "";
                    OleDbDataAdapter myCommand = null;
                    strExcel = string.Format("select * from [{0}$]", "Sheet1"); //Sheet1为excel中工作薄
                    myCommand = new OleDbDataAdapter(strExcel, strConn);
                    myCommand.Fill(ds, "Sheet1");
                    DataTable dt = ds.Tables["Sheet1"];
                    Encoding gb2312 = Encoding.GetEncoding("GB2312");

                    for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                    {
                        BaseInfoMemberTester bifmt = BaseInfoMemberTester.New;
                        bifmt.Mobile = dt.Rows[iRow][0].ToString();
                        bifmt.Name = dt.Rows[iRow][1].ToString();
                        bifmt.Description = dt.Rows[iRow][2].ToString();
                        bifmt.PinYin = PinYinTransfer.GetInitials(bifmt.Name, gb2312);
                        bifmt.TestDate = (DateTime)dt.Rows[iRow][3];
                        bifmt.FinishedDate = (DateTime)dt.Rows[iRow][4];
                        bifmt.Status = "0";
                        bifmt.OptrType = UserStatics.OptrType;
                        bifmt.Save();

                    }
                }
                MessageBox.Show("导入成功！");

            }
            catch (Exception ex)
            {
                MessageBox.Show("导入有问题，日期精确到秒,日期列要设为日期格式，并且数值类型如没有必须用0代替！\n" + ex);
            }
        }

        override protected void DeleteCurrentRow()
        {
            BllBaseInfoMemberTester.DelCell(DeletingRowId);
        }

        protected override string SetFilterString()
        {
            return "简拼 like '%" + tbFind.Text + "%' or 姓名 like '%" + tbFind.Text + "%' or 手机 like '%" + tbFind.Text + "%' ";
        }

    }
}
