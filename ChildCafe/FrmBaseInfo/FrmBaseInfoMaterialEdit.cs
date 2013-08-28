using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoMaterialEdit : XSolo.BaseForm.FrmAddEdit
    {
        public FrmBaseInfoMaterialEdit()
        {
            InitializeComponent();
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
            }
        }

        private void ctUnitConvValue_ValueChanged(object sender, EventArgs e)
        {
            if (ctUnitConvValue.Value != 0)
            {
                ctConvPrice.Value = ctUnitPrice.Value / ctUnitConvValue.Value;
                ctConvQuantity.Value = ctInvQuantity.Value * ctUnitConvValue.Value;
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
    }
}
