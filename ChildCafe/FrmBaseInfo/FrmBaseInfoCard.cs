using ChildCafe.Bll;
using ChildCafe.Common;
using ChildCafe.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoCard : XSolo.BaseForm.FrmBTree
    {
        public FrmBaseInfoCard()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmBaseInfoCard_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            //BaseInfoCard bic = BaseInfoCard.New;
            //bic.JoinedDate = Convert.ToDateTime("2014-5-1 00:00:00");
            //bic.CardNumber = "111";
            //bic.ChildName = "test";
            //bic.CardType = BaseInfoCardType.十次卡.ToString();
            //bic.CountLeft = 0;
            //bic.ExpirationDate = Convert.ToDateTime("2015-5-1 00:00:00");
            //bic.CardStatus = (int)BaseInfoCardStatus.使用;
            //bic.OptrType = UserStatics.OptrType;
            //bic.Save();
            //if (IsSelect == true)
            //    TableForLoad = BllBaseInfoCard.GetPartTable(UserStatics.OptrType);
            //else
            TableForLoad = BllBaseInfoCard.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            //baseDataGridView.Columns[IdNameInTable].Visible = false;
            //baseDataGridView.Columns["用户类型"].Visible = false;

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
                for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                {
                    BaseInfoCard bic = BaseInfoCard.New;
                    bic.JoinedDate = (DateTime)dt.Rows[iRow][0];
                    bic.CardNumber = dt.Rows[iRow][1].ToString();
                    bic.ChildName = dt.Rows[iRow][2].ToString();
                    bic.Mobile = dt.Rows[iRow][3].ToString();
                    bic.CardType = dt.Rows[iRow][4].ToString();
                    bic.CountLeft = decimal.Parse(dt.Rows[iRow][5].ToString());

                    DateTime dtime = (DateTime)dt.Rows[iRow][0];
                    bic.ExpirationDate = dtime.AddYears(1);

                    bic.Remark = dt.Rows[iRow][7].ToString();
                    bic.CardStatus = 1;
                    bic.PinYin = PinYinTransfer.GetInitials(bic.ChildName, gb2312);
                    bic.SavedOn = DateTime.Now;
                    bic.OptrType = UserStatics.OptrType;
                    bic.Save();
                }
            }
        }

        protected override void resetDataGridView()
        {
            TableForLoad = BllBaseInfoCard.GetTable(UserStatics.OptrType);
            reloadDataGridView();
        }

        protected override string SetFilterString()
        {
            return "简拼 like '%" + tbFind.Text + "%' or 宝宝名 like '%" + tbFind.Text + "%' or 卡号 like '%" + tbFind.Text + "%'";
        }

    }
}
