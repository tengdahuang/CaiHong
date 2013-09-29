using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Common;
using ChildCafe.Dal;
using ChildCafe.Bll;
using Lephone.Data;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmSupplyChainPos : XSolo.BaseForm.FrmBCommonBlank
    {
        private long PosId;
        private long MemberId;
        private DataTable TableForSelectItem;
        private DataTable TableForPosDetail;

        private long MaterialId ;

        public FrmSupplyChainPos()
        {
            InitializeComponent();
        }

        private void FrmSupplyChainPos_Load(object sender, EventArgs e)
        {
            TableForSelectItem = BllBaseInfoMaterial.GetTable(UserStatics.OptrType);
            ReloadDgvSelectItem();


            
            ctMealTableName.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "桌号");
            ctMealTableName.DisplayMember = "Name";

            //1.取出最新的流水号，新增并保存一张未结算pos单
            SupplyChainPos fscp = SupplyChainPos.New;
            fscp.SerialNumber = BllSupplyChainPos.GetPosSN();
            //fscp.SerialNumber = "00000000000";
            fscp.PosDateTime = DateTime.Now;
            fscp.Cashier = UserStatics.ChineseName;
            //fscp.Quantity = 0;
            //fscp.PaidQuantity = 0;
            //fscp.UnPaidQuantity = 0;
            //fscp.GiftQuantity = 0;
            //fscp.PosAmount = 0;
            //fscp.UnPayAmount = 0;
            //fscp.PayInAmount = 0;
            //fscp.PayByStoredValueCard = 0;
            //fscp.PayByCash = 0;
            //fscp.PayByCoupons = 0;
            //fscp.PayByBank = 0;
            //fscp.PosProfit = 0;
            fscp.IsAllPaid = false;
            fscp.IsHolded = false;
            fscp.Save();
            PosId = fscp.Id;

            FrmAddEditBindComboBoxText.BindObjectToControls(fscp, panelTop);
            FrmAddEditBindComboBoxText.BindObjectToControls(fscp, panelBottom);


        }

        private void FrmSupplyChainPos_KeyDown(object sender, KeyEventArgs e)
        {
            RaiseKeyEvents(e);
        }

        private void RaiseKeyEvents(KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SendKeys.Send("{Tab}");
            //}
            if (e.KeyCode == Keys.F2)
            {
                RaiseMemberSearchWindow();
            }
            if (e.KeyCode == Keys.F1)
            {
                ctMealTableName.Focus();
            }
            if (e.KeyCode == Keys.F7)
            {
                tbSelectItem.Focus();
            }

        }

        private void RaiseMemberSearchWindow()
        {
            FrmBaseInfoMember fim = new FrmBaseInfoMember(); ;
            fim.IsSelect = true;
            fim.Text = "请选择会员";
            fim.ShowDialog();
            MemberId = fim.SelectedValue;
            //返回的SelectedValue,取出SelectedValue的EquipmentInformation
            BaseInfoMember bim = BaseInfoMember.FindById(fim.SelectedValue);
            //绑定各个控件
            FrmAddEditBindComboBoxText.BindObjectToControls(bim, panelTop);
            fim.Dispose();
        }


        private void FrmSupplyChainPos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PosId != 0)
            {
                SupplyChainPos fscp = SupplyChainPos.FindById(PosId);

                //1.如果当前单据没有子项，则删单
                if (fscp.Quantity == 0)
                {
                    fscp.Delete();
                }
                //2.如果当前单据有子项,
                //2a.如果是挂单，则什么也不做
                //2b.如果不是挂单，则提示是否要保留，
                //2ba.如果保留则自动进入挂单
                //2bb.否则删除子项和当前单据
                else if (fscp.Quantity != 0)
                {
                    if (fscp.IsHolded == false)
                    {
                        DialogResult dr = MessageBox.Show("当前单据未挂单，是否要保留", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dr == DialogResult.OK)
                        {
                            fscp.IsHolded = true;
                            fscp.Save();
                        }
                        else
                        {
                            fscp.Delete();
                        }

                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSelectItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SupplyChainPos scp = SupplyChainPos.FindById(PosId);
                SupplyChainPosDetail scpd = SupplyChainPosDetail.New;
                BaseInfoMaterial bim = BaseInfoMaterial.FindById(MaterialId);
                scpd.IsPaid = false;
                scpd.MaterialId = bim.Id;
                scpd.MaterialName = bim.Name;
                scpd.MaterialCategory = bim.Category;
                scpd.UnitName = bim.SaleUnitName;
                scpd.UnitPrice = bim.ConvPrice;
                scpd.Quantity = 1;
                scpd.Discount = 0;
                scpd.Amount = scpd.UnitPrice*scpd.Quantity;
                scpd.IsReturns = false;
                scpd.IsGift = false;
                scpd.OrderDateTime = DateTime.Now;
                scpd.Save();
                scp.SupplyChainPosDetails.Add(scpd);
                scp.Quantity += 1;
                scp.UnPaidQuantity += 1;
                scp.UnPayAmount += scpd.Amount;
                scp.Cashier = UserStatics.ChineseName;
                scp.Save();
                bim.ConvQuantity -= 1;
                bim.InvQuantity = bim.ConvQuantity/bim.UnitConvValue;
                bim.Save();

                TableForPosDetail = BllSupplyChainPos.GetPosDetail(PosId);
                ReloadDgvPosDetail();
            }
            if (e.KeyCode == Keys.Down)
            {
                bsSelectItem.MoveNext();
            }
            if (e.KeyCode == Keys.Up)
            {
                bsSelectItem.MovePrevious();
            }
        }

        private void tbSelectItem_TextChanged(object sender, EventArgs e)
        {
            if (SetFilterString() != "")
            {
                bsSelectItem.Filter = SetFilterString();
                dgvSelectItem.DataSource = bsSelectItem;
            }

        }

        /// <summary>
        /// 取得过滤字符串
        /// </summary>
        /// <returns>过滤字符串</returns>
        private string SetFilterString()
        {
            return "简拼 like '%" + tbSelectItem.Text + "%' or 商品编码 like '%" + tbSelectItem.Text + "%' or 商品名称 like '%" + tbSelectItem.Text + "%' or 商品分类 like '%" + tbSelectItem.Text + "%'";
        }

        virtual protected void ReloadDgvSelectItem()
        {
            dgvSelectItem.DataSource = null;
            bsSelectItem.DataSource = TableForSelectItem;
            dgvSelectItem.DataSource = bsSelectItem;
        }

        virtual protected void ReloadDgvPosDetail()
        {
            dgvPosDetail.DataSource = null;
            bsPosDetail.DataSource = TableForPosDetail;
            dgvPosDetail.DataSource = bsPosDetail;
        }

        private void dgvSelectItem_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvSelectItem.CurrentRow != null)
            {
                if (this.dgvSelectItem.CurrentRow.Cells["Id"].Value != null)
                {
                    this.MaterialId = long.Parse(this.dgvSelectItem.CurrentRow.Cells["Id"].Value.ToString());

                }
            }
        }







    }
}
