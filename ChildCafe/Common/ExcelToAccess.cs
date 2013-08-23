using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using Lephone.Data;
using ChildCafe.Dal;
using XSolo.Common;

namespace ChildCafe.Common
{
    public class ExcelToAccess
    {
        public static void ImportToAccess(string tableName)
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

                for(int iRow=1; iRow < dt.Rows.Count; iRow++)
                {
                    BaseInfoMember bifm = BaseInfoMember.New;
                    bifm.CardNumber = dt.Rows[iRow][0].ToString();
                    bifm.Name = dt.Rows[iRow][1].ToString();
                    bifm.PinYin = AutoPinYin.GetPinYin(bifm.Name);
                    bifm.Password = dt.Rows[iRow][3].ToString();
                    bifm.Birth = (DateTime) dt.Rows[iRow][4];
                    bifm.Mobile = dt.Rows[iRow][5].ToString();
                    bifm.Phone = dt.Rows[iRow][6].ToString();
                    bifm.DiscountRate = (decimal)dt.Rows[iRow][7];
                    bifm.RemainingSum = (decimal)dt.Rows[iRow][8];
                    bifm.TotalBonusPoint = (decimal)dt.Rows[iRow][9];
                    bifm.Frequency = (decimal)dt.Rows[iRow][10];
                    bifm.TotalSpending = (decimal)dt.Rows[iRow][11];
                    bifm.Description = dt.Rows[iRow][12].ToString();
                    bifm.SavedOn = (DateTime)dt.Rows[iRow][13];
                    bifm.OptrType = UserStatics.OptrType;
                    bifm.Save();
                    
                }
                

                //DbEntry.Context.UsingConnection(delegate()
                //{
                //    IDbBulkCopy c = DbEntry.Context.GetDbBulkCopy();
                //    c.BatchSize = 10;
                //    c.DestinationTableName = tableName;
                //    c.NotifyAfter = 10;
                //    //c.SqlRowsCopied += new SqlRowsCopiedEventHandler(
                //    //    delegate(object sender, SqlRowsCopiedEventArgs e)
                //    //    {
                //    //        Console.WriteLine("{0} rows copied.", e.RowsCopied);
                //    //    });
                //    c.WriteToServer(dt);
                //});

            }
        }

    }
}
