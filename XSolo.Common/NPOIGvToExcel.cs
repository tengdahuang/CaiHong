using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;

namespace XSolo.Common
{
    public class NPOIGvToExcel
    {
        #region DataGridView导出到Excel，有一定的判断性
        /// <summary> 
        ///方法，导出DataGridView中的数据到Excel文件 
        /// </summary> 
        /// <remarks>
        /// add com "Microsoft Excel 11.0 Object Library"
        /// using Excel=Microsoft.Office.Interop.Excel;
        /// using System.Reflection;
        /// </remarks>
        /// <param name= "dgv"> DataGridView </param> 
        public static void DataGridViewToExcel(DataGridView dgv)
        {


            #region   验证可操作性

            //申明保存对话框 
            SaveFileDialog dlg = new SaveFileDialog();
            //默然文件后缀 
            dlg.DefaultExt = "xls ";
            //文件后缀列表 
            dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
            //默然路径是系统当前路径 
            dlg.InitialDirectory = @"C:\";
            dlg.FileName = DateTime.Now.ToString("yyMMddhhmmss");
            //打开保存对话框 
            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            //返回文件路径 
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效 
            if (fileNameString.Trim() == " ")
            { return; }
            //定义表格内数据的行数和列数 
            int rowscount = dgv.Rows.Count;
            int colscount = dgv.Columns.Count;
            //行数必须大于0 
            if (rowscount <= 0)
            {
                MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //列数必须大于0 
            if (colscount <= 0)
            {
                MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //行数不可以大于65536 
            if (rowscount > 65536)
            {
                MessageBox.Show("数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //列数不可以大于255 
            if (colscount > 255)
            {
                MessageBox.Show("数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //验证以fileNameString命名的文件是否存在，如果存在删除它 
            FileInfo file = new FileInfo(fileNameString);
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            #endregion

            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            hssfworkbook = new HSSFWorkbook();

            //create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "HS";
            hssfworkbook.DocumentSummaryInformation = dsi;

            //create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "HSEMS";
            hssfworkbook.SummaryInformation = si;

            //Microsoft.Office.Interop.Excel.Application objExcel = null;
            //Microsoft.Office.Interop.Excel.Workbook objWorkbook = null;
            //Microsoft.Office.Interop.Excel.Worksheet objsheet = null;
            try
            {
                //申明对象 
                //here, we must insert at least one sheet to the workbook. otherwise, Excel will say 'data lost in file'
                //So we insert three sheet just like what Excel does
                ISheet sheet1 = hssfworkbook.CreateSheet("Sheet1");
                //objExcel = new Microsoft.Office.Interop.Excel.Application();
                //objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                //objsheet = (Microsoft.Office.Interop.Excel.Worksheet)objWorkbook.ActiveSheet;
                ////设置EXCEL不可见 
                //objExcel.Visible = false;

                //向Excel中写入表格的表头 
                IRow row1 = sheet1.CreateRow(0);
                int displayColumnsCount = 0;
                for (int i = 0; i <= dgv.ColumnCount - 1; i++)
                {
                    if (dgv.Columns[i].Visible == true)
                    {
                        row1.CreateCell(displayColumnsCount).SetCellValue(dgv.Columns[i].HeaderText.Trim());
                        //objExcel.Cells[1, displayColumnsCount] = dgv.Columns[i].HeaderText.Trim();
                        displayColumnsCount++;
                    }
                }
                //设置进度条 
                //tempProgressBar.Refresh(); 
                //tempProgressBar.Visible   =   true; 
                //tempProgressBar.Minimum=1; 
                //tempProgressBar.Maximum=dgv.RowCount; 
                //tempProgressBar.Step=1; 
                #region 导出详细数据
                //向Excel中逐行逐列写入表格中的数据 
                IRow row2;
                for (int row = 1; row <= dgv.RowCount; row++)
                {
                    //tempProgressBar.PerformStep(); 
                    row2 = sheet1.CreateRow(row);
                    displayColumnsCount = 0;
                    for (int col = 0; col < colscount; col++)
                    {
                        if (dgv.Columns[col].Visible == true)
                        {
                            try
                            {
                                row2.CreateCell(displayColumnsCount).SetCellValue(dgv.Rows[row-1].Cells[col].Value.ToString().Trim());
                                //objExcel.Cells[row + 2, displayColumnsCount] = dgv.Rows[row].Cells[col].Value.ToString().Trim();
                                displayColumnsCount++;
                            }
                            catch (Exception)
                            {

                            }

                        }
                    }
                }
                #endregion
                //隐藏进度条 
                //tempProgressBar.Visible   =   false; 
                //保存文件 
                //objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                //        Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                //        Missing.Value, Missing.Value);
                //Write the stream data of workbook to the root directory
                FileStream fs = new FileStream(fileNameString, FileMode.Create);
                hssfworkbook.Write(fs);
                fs.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "警告 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                hssfworkbook = null;
                //关闭Excel应用 
                //if (objWorkbook != null) objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);
                //if (objExcel.Workbooks != null) objExcel.Workbooks.Close();
                //if (objExcel != null) objExcel.Quit();

                //objsheet = null;
                //objWorkbook = null;
                //objExcel = null;
                MessageBox.Show(fileNameString + "\n\n导出完毕! ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        #endregion
    }
}
