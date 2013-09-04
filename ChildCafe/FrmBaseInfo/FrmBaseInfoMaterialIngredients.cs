using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Bll;
using ChildCafe.Common;
using ChildCafe.Dal;
using Lephone.Data;

namespace ChildCafe
{
    public partial class FrmBaseInfoMaterialIngredients : Form
    {
        public string BaseParentId { get; set; }
        /// <summary>
        /// 私有成员，用于记录点击datagridview时的该条记录的Id
        /// </summary>
        private string _itemId;

        /// <summary>
        /// 保护成员，该表第一列ID在数据库中的实际名称
        /// </summary>
        protected string IdNameInTable { get; set; }

        public FrmBaseInfoMaterialIngredients()
        {
            InitializeComponent();
        }

        private void FrmBaseInfoMaterialIngredients_Load(object sender, EventArgs e)
        {
            IdNameInTable = "Id";
            bsSrc.DataSource = BllBaseInfoMaterialIngredients.GetSrcTable(UserStatics.OptrType);
            dgvSrc.DataSource = bsSrc;

            bsDest.DataSource = BllBaseInfoMaterialIngredients.GetDestTable(UserStatics.OptrType, BaseParentId);
            dgvDest.DataSource = bsDest;

        }

        private void tbShortCode_TextChanged(object sender, EventArgs e)
        {
            if (SetFilterString() != "")
            {
                bsSrc.Filter = SetFilterString();
                dgvSrc.DataSource = bsSrc;
            }
        }

        private string SetFilterString()
        {
            return "简拼 like '%" + tbShortCode.Text + "%' or 编码 like '%" + tbShortCode.Text + "%'";
        }

        private void tbShortCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAmount.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                bsSrc.MoveNext();
            }
            if (e.KeyCode == Keys.Up)
            {
                bsSrc.MovePrevious();
            }
        }

        private void dgvSrc_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvSrc.CurrentRow != null)
            {
                if (this.dgvSrc.CurrentRow.Cells[IdNameInTable].Value != null)
                {
                    this._itemId = this.dgvSrc.CurrentRow.Cells[IdNameInTable].Value.ToString();
                }
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{Tab}");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //1.判断右边有无该编码
            if (
                BaseInfoMaterialIngredient.GetCount(CK.K["BaseInfoMaterial_Id"] == BaseParentId &&
                                                    CK.K["IngredientId"] == _itemId) != 0)
            {
                MessageBox.Show("该物料已经添加");
            }
            //2.在右边加入该成品
            else
            {
                BaseInfoMaterial bim = BaseInfoMaterial.FindById(long.Parse(BaseParentId));
                BaseInfoMaterial bimChild = BaseInfoMaterial.FindById(long.Parse(_itemId));
                BaseInfoMaterialIngredient baseInfoMaterialIngredient = BaseInfoMaterialIngredient.New;
                baseInfoMaterialIngredient.IngredientId = long.Parse(_itemId);
                baseInfoMaterialIngredient.MaterialName = bimChild.Name;
                baseInfoMaterialIngredient.Price = bimChild.ConvPrice;
                baseInfoMaterialIngredient.Quantity = Decimal.Parse(tbAmount.Text);
                baseInfoMaterialIngredient.Cost = baseInfoMaterialIngredient.Price * baseInfoMaterialIngredient.Quantity;
                baseInfoMaterialIngredient.OptrType = UserStatics.OptrType;
                baseInfoMaterialIngredient.Save();
                bim.BaseInfoMaterialIngredients.Add(baseInfoMaterialIngredient);
                bim.Save();
            }
            //3.刷新右边的dgv
            bsDest.DataSource = null;
            bsDest.DataSource = BllBaseInfoMaterialIngredients.GetDestTable(UserStatics.OptrType, BaseParentId);
            dgvDest.DataSource = bsDest;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //删除记录
            if (MessageBox.Show("确认删除这(条/些)记录吗？", "询问",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (dgvDest.Rows.Count > 0)
                    {
                        int count = 0;

                        foreach (DataGridViewRow row in dgvDest.SelectedRows)
                        {
                            string delId = row.Cells["Id"].Value.ToString();
                            BaseInfoMaterialIngredient.DeleteAll(CK.K["Id"] == delId);
                            count++;
                        }
                        MessageBox.Show("已删除" + count + "条记录！");
                    }
                    else
                    {
                        MessageBox.Show("没有可删除的数据", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bsDest.DataSource = null;
            bsDest.DataSource = BllBaseInfoMaterialIngredients.GetDestTable(UserStatics.OptrType, BaseParentId);
            dgvDest.DataSource = bsDest;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
