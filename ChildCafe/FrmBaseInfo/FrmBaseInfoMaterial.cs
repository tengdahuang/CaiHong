using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;

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
            BllBaseInfoMaterial.DelCell(DeletingRowId);
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
    }
}
