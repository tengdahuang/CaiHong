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
    public partial class FrmBaseInfoMaterial : XSolo.BaseForm.FrmBTree
    {
        public FrmBaseInfoMaterial()
        {
            InitializeComponent();
            splitContainer1.Panel1Collapsed = true;
        }

        private void FrmBaseInfoMaterial_Load(object sender, EventArgs e)
        {

        }

        protected override void InitData()
        {
            ActionTable = UserStatics.GetUserActions(ModuleId);
            TableForLoad = BllBaseInfoMaterial.GetTable(UserStatics.OptrType);
        }

        protected override void SetDataGridViewColumns()
        {
            baseDataGridView.Columns[IdNameInTable].Visible = false;
            baseDataGridView.Columns["用户类型"].Visible = false;

        }

        protected override void SetIngredientOptration()
        {
            FrmBaseInfoMaterialIngredients frmBaseInfoMaterialIngredients = new FrmBaseInfoMaterialIngredients();
            frmBaseInfoMaterialIngredients.BaseParentId = baseDataGridView.SelectedRows[0].Cells[IdNameInTable].Value.ToString();
            frmBaseInfoMaterialIngredients.ShowDialog();
        }

        override protected void DeleteCurrentRow()
        {
            BaseInfoMaterial bim = BaseInfoMaterial.FindById(DeletingRowId);
            if(bim.BaseInfoMaterialIngredients.Count == 0)
            { BllBaseInfoMaterial.DelCell(DeletingRowId); }
            else
            {
                MessageBox.Show("请先删除该商品组成耗材关系!");
            }

        }

        protected override void resetDataGridView()
        {
            TableForLoad = BllBaseInfoMaterial.GetTable(UserStatics.OptrType);
            reloadDataGridView();
        }

        protected override string SetFilterString()
        {
            return "简拼 like '%" + tbFind.Text + "%' or 商品编码 like '%" + tbFind.Text + "%' or 商品名称 like '%" + tbFind.Text + "%' or 商品分类 like '%" + tbFind.Text + "%'";
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
                for (int iRow = 1; iRow < dt.Rows.Count; iRow++)
                {
                    BaseInfoMaterial bim = BaseInfoMaterial.New;
                    bim.Code = dt.Rows[iRow][0].ToString();
                    bim.Name = dt.Rows[iRow][1].ToString();
                    bim.ShortCode = PinYinTransfer.GetInitials(bim.Name, gb2312);
                    bim.Barcode = bim.ShortCode;
                    bim.Category = dt.Rows[iRow][4].ToString();
                    bim.Specification = dt.Rows[iRow][5].ToString();
                    bim.ItemNo = dt.Rows[iRow][6].ToString();
                    bim.Brand = dt.Rows[iRow][7].ToString();
                    bim.PurchaseUnitName = dt.Rows[iRow][8].ToString();
                    bim.SaleUnitName = dt.Rows[iRow][9].ToString();
                    bim.UnitConvValue = decimal.Parse(dt.Rows[iRow][10].ToString());
                    bim.UnitPrice = decimal.Parse(dt.Rows[iRow][11].ToString());
                    if (bim.UnitPrice == 0)
                    {
                        bim.ConvPrice = 0;}
                    else
                    {
                        bim.ConvPrice = bim.UnitPrice / bim.UnitConvValue;
                    }
                    bim.AvgPrice = bim.ConvPrice;
                    bim.RetailPrice = decimal.Parse(dt.Rows[iRow][14].ToString());
                    bim.MemberPrice = decimal.Parse(dt.Rows[iRow][15].ToString());
                    bim.InvQuantity = decimal.Parse(dt.Rows[iRow][16].ToString());
                    bim.ConvQuantity = bim.InvQuantity * bim.UnitConvValue;
                    bim.InventoryCost = bim.ConvPrice * bim.ConvQuantity;
                    bim.StockLowAlarm = decimal.Parse(dt.Rows[iRow][19].ToString());
                    bim.BonusPoint = decimal.Parse(dt.Rows[iRow][20].ToString());
                    bim.IsAddToInventory = (bool)dt.Rows[iRow][21];
                    bim.IsIngredient = (bool)dt.Rows[iRow][22];
                    bim.Status = dt.Rows[iRow][23].ToString();
                    bim.Remark = dt.Rows[iRow][24].ToString();
                    bim.OptrType = UserStatics.OptrType;
                    bim.SavedOn = DateTime.Now;
                    bim.Save();

                }
            }
        }

    }
}
