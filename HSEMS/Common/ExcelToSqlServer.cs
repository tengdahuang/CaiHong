using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace HSEMS.Common
{
    public class ExcelToSqlServer
    {
        public static void ImportToSQL(string tableName)
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
                strExcel = string.Format("select * from [{0}$]", "Sheet1"); //Bicycle为excel中工作薄
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(ds, "Sheet1");
                DataTable dt = ds.Tables["Sheet1"];


                DbEntry.Context.UsingConnection(delegate()
                {
                    IDbBulkCopy c = DbEntry.Context.GetDbBulkCopy();
                    c.BatchSize = 10;
                    c.DestinationTableName = tableName;
                    c.NotifyAfter = 10;
                    //c.SqlRowsCopied += new SqlRowsCopiedEventHandler(
                    //    delegate(object sender, SqlRowsCopiedEventArgs e)
                    //    {
                    //        Console.WriteLine("{0} rows copied.", e.RowsCopied);
                    //    });
                    c.WriteToServer(dt);
                });

            }
        }
    }
}
