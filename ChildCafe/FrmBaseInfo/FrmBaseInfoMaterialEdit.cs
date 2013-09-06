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
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoMaterialEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmBaseInfoMaterialEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            ctIsAddToInventory.Checked = true;
            ctUnitConvValue.Value = 1;

            ctCategory.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "物料分类");
            ctCategory.DisplayMember = "Name";

            ctPurchaseUnitName.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "单位");
            ctPurchaseUnitName.DisplayMember = "Name";

            ctSaleUnitName.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "单位");
            ctSaleUnitName.DisplayMember = "Name";


            if (!IsAdd)
            {
                var obj = BaseInfoMaterial.FindById(long.Parse(ItemID));
                BindControlsDecimal.BindObjectToControls(obj, tabPage1);
                BindControlsDecimal.BindObjectToControls(obj, tabPage2);

                //ReSetNumbericUpDownStatus();
                bsIngredients.DataSource = BllBaseInfoMaterialIngredients.GetDestTable(UserStatics.OptrType, ItemID);
                dgvIngredients.DataSource = bsIngredients;

            }


            
        }

        protected override void Saving()
        {
            if (!IsAdd)
            {
                var obj = BaseInfoMaterial.FindById(long.Parse(ItemID));
                BindControlsDecimal.BindControlsToObject(obj, tabPage1);
                BindControlsDecimal.BindControlsToObject(obj, tabPage2);
                obj.Save();
            }
            else
            {
                var obj = BaseInfoMaterial.New;
                BindControlsDecimal.BindControlsToObject(obj, tabPage1);
                BindControlsDecimal.BindControlsToObject(obj, tabPage2);
                obj.OptrType = UserStatics.OptrType;
                obj.Save();
            }

        }

        private void ctIsAddToInventory_CheckedChanged(object sender, EventArgs e)
        {
            if (ctIsAddToInventory.Checked)
            {
                IsIncludeIngredient.Checked = false;
                IsIncludeIngredient.Enabled = false;
                chooseIngredient.Enabled = false;
                dgvIngredients.Enabled = false;
            }
            else
            {
                IsIncludeIngredient.Checked = true;
                IsIncludeIngredient.Enabled = true;
                chooseIngredient.Enabled = true;
                dgvIngredients.Enabled = true;
            }
        }

        private void ctName_TextChanged(object sender, EventArgs e)
        {
            ctShortCode.Text = AutoPinYin.GetPinYin(ctName.Text);
        }


        private void ctUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            if (ctUnitConvValue.Value != 0)
            {
                ctConvPrice.Value = ctUnitPrice.Value / ctUnitConvValue.Value;
                ctConvQuantity.Value = ctInvQuantity.Value*ctUnitConvValue.Value;
                ctInventoryCost.Value = ctConvPrice.Value * ctConvQuantity.Value;
            }
        }

        private void ctUnitConvValue_ValueChanged(object sender, EventArgs e)
        {
            if (ctUnitConvValue.Value != 0)
            {
                ctConvPrice.Value = ctUnitPrice.Value / ctUnitConvValue.Value;
                ctConvQuantity.Value = ctInvQuantity.Value * ctUnitConvValue.Value;
                ctInventoryCost.Value = ctConvPrice.Value * ctConvQuantity.Value;
            }
        }

        private void ctInvQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (ctUnitConvValue.Value != 0)
            {
                ctConvQuantity.Value = ctInvQuantity.Value * ctUnitConvValue.Value;
                ctInventoryCost.Value = ctConvPrice.Value*ctConvQuantity.Value;
            }
        }

        private void ctCode_TextChanged(object sender, EventArgs e)
        {
            ctBarcode.Text = ctCode.Text;
        }

        private void ctPurchaseUnitName_TextChanged(object sender, EventArgs e)
        {
            ctSaleUnitName.Text = ctPurchaseUnitName.Text;
        }

        private void ctCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctCategory.Text == "半成品") ctIsIngredient.Checked = true;
            else ctIsIngredient.Checked = false;
        }

        private void chooseIngredient_Click(object sender, EventArgs e)
        {
            if (!IsAdd)
            {
                FrmBaseInfoMaterialIngredients frmBaseInfoMaterialIngredients = new FrmBaseInfoMaterialIngredients();
                frmBaseInfoMaterialIngredients.BaseParentId = ItemID;
                frmBaseInfoMaterialIngredients.ShowDialog();
                bsIngredients.DataSource = null;
                bsIngredients.DataSource = BllBaseInfoMaterialIngredients.GetDestTable(UserStatics.OptrType, ItemID);
                dgvIngredients.DataSource = bsIngredients;

            }
            else
            {
                MessageBox.Show("请先保存该商品!");
            }
        }
    }
}
