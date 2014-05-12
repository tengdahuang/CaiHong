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
        private long MemberId = 0;
        private DataTable TableForSelectItem;
        private DataTable TableForPosDetail;

        private long MaterialId;

        public FrmSupplyChainPos()
        {
            InitializeComponent();
        }

        private void FrmSupplyChainPos_Load(object sender, EventArgs e)
        {
            TableForSelectItem = BllBaseInfoMaterial.GetTable(UserStatics.OptrType);
            bsSelectItem.DataSource = TableForSelectItem;

            ctMealTableName.DataSource = CommonStatics.GetDict(UserStatics.OptrType, "桌号");
            ctMealTableName.DisplayMember = "Name";

            InitialPos();

        }

        private void InitialPos()
        {
            dgvSelectItem.DataSource = null;

            bsPosDetail.DataSource = null;
            dgvPosDetail.DataSource = null;

            //1.取出最新的流水号，新增并保存一张未结算pos单
            SupplyChainPos fscp = SupplyChainPos.New;
            fscp.SerialNumber = BllSupplyChainPos.GetPosSN();
            //fscp.SerialNumber = "00000000000";
            fscp.PosDateTime = DateTime.Now;
            fscp.Cashier = UserStatics.ChineseName;
            fscp.Quantity = 0;
            fscp.PaidQuantity = 0;
            fscp.UnPaidQuantity = 0;
            fscp.GiftQuantity = 0;
            fscp.PosAmount = 0;
            fscp.UnPayAmount = 0;
            fscp.PayInAmount = 0;
            fscp.PayByStoredValueCard = 0;
            fscp.PayByCash = 0;
            fscp.PayByCoupons = 0;
            fscp.PayByBank = 0;
            fscp.PosProfit = 0;
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
            if (e.KeyCode == Keys.F1)
            {
                RaiseMemberSearchWindow();
            }

            if (e.KeyCode == Keys.F2)
            {
                ctMealTableName.Focus();
            }

            if (e.KeyCode == Keys.F3)
            {
                tbSelectItem.Focus();
            }
            if (e.KeyCode == Keys.F4)
            {
                ctRealPay.Focus();
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
            if (MemberId != 0)
            {
                BaseInfoMember bim = BaseInfoMember.FindById(MemberId);
                //绑定各个控件
                FrmAddEditBindComboBoxText.BindObjectToControls(bim, panelTop);
                if (bim.RemainingSum > 0)
                {
                    ctRemainingSum.Text = bim.RemainingSum.ToString();
                    lbRemainingSum.Visible = true;
                    ctRemainingSum.Visible = true;
                }
            }

            fim.Dispose();
        }


        private void FrmSupplyChainPos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PosId != 0)
            {
                SupplyChainPos fscp = SupplyChainPos.FindById(PosId);

                //1.如果当前单据没有子项，则删单
                //2.如果当前单据有子项,
                //2a.如果是挂单，则什么也不做
                //2b.如果不是挂单，则提示是否要保留，
                //2ba.如果保留则自动进入挂单
                //2bb.否则删除子项和当前单据
                if (fscp.Quantity == 0)
                {
                    fscp.Delete();
                }
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
                            SupplyChainPosDetail.DeleteAll(CK.K["SupplyChainPosId"] == PosId);
                            fscp.SupplyChainPosDetails.Clear();
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
            //选好单品，并且回车
            if (e.KeyCode == Keys.Enter && tbSelectItem.Text != "")
            {
                SupplyChainPos scp = SupplyChainPos.FindById(PosId);
                SupplyChainPosDetail scpd = SupplyChainPosDetail.New;
                BaseInfoMaterial bim = BaseInfoMaterial.FindById(MaterialId);
                scpd.IsPaid = false;
                scpd.MaterialId = bim.Id;
                scpd.MaterialName = bim.Name;
                scpd.MaterialCategory = bim.Category;
                scpd.UnitName = bim.SaleUnitName;
                if (scp.MemberId != 0)
                {
                    scpd.UnitPrice = bim.MemberPrice;
                }
                else
                {
                    scpd.UnitPrice = bim.RetailPrice;
                }
                scpd.Quantity = 1;
                scpd.Discount = 0;
                scpd.Amount = scpd.UnitPrice * scpd.Quantity;
                scpd.IsReturns = false;
                scpd.IsGift = false;
                scpd.OrderDateTime = DateTime.Now;
                scpd.Save();
                scp.SupplyChainPosDetails.Add(scpd);
                scp.Quantity += 1;
                scp.UnPaidQuantity += 1;
                scp.UnPayAmount += scpd.Amount;
                scp.PosAmount += scpd.Amount;
                scp.Cashier = UserStatics.ChineseName;
                scp.Save();
                bim.ConvQuantity -= 1;
                bim.InvQuantity = bim.ConvQuantity / bim.UnitConvValue;
                bim.Save();

                FrmAddEditBindComboBoxText.BindObjectToControls(scp, panelBottom);

                TableForPosDetail = BllSupplyChainPos.GetPosDetail(PosId);
                ReloadDgvPosDetail();
                foreach (DataGridViewRow row in dgvPosDetail.Rows)
                {
                    row.Selected = true;
                }
                tbSelectItem.Text = "";
                ctUnderPay.Text = scp.UnPayAmount.ToString();
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
            if (tbSelectItem.Text == "")
            {
                dgvSelectItem.DataSource = null;
            }
            else
            {
                if (SetFilterString() != "")
                {
                    bsSelectItem.Filter = SetFilterString();
                    dgvSelectItem.DataSource = bsSelectItem;
                }
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

        private void btnFullPay_Click(object sender, EventArgs e)
        {
                                    BaseInfoMember bim = BaseInfoMember.FindById(MemberId);

            if (ctCardNumber.Text == "" && ctMemberName.Text.Trim() != "")
            {
                MessageBox.Show("本单据看到会员名称，却看不到会员号，请确认会员号不能为空!");
            }
            else
            {
                //判断是否存在会员ID

                //1.如果会员ID不存在
                //1a.实收<应收，则提示实收款不足
                //2b.实收>=应收，则完成正常结算
                if (MemberId == 0)
                {
                    if (ctRealPay.Value < decimal.Parse(ctUnderPay.Text))
                    {
                        MessageBox.Show("实收不足以支付当前应收金额！");
                    }
                    else
                    {
                        PayAllDue();

                        //3.弹出支付完成提示窗口
                        //todo 需要初始化POS数据，增加单号
                        MessageBox.Show("已经完成结算！");
                    }
                }
                //2.会员ID存在
                //1a.会员存款>应收，直接扣除会员存款，完成结算
                //1b.会员存款<应收，
                //1ba.如果存款+实付 > 应收，完成结算，会员存款清零，并提示
                else
                {
                    if (decimal.Parse(ctRemainingSum.Text) >= decimal.Parse(ctUnderPay.Text))
                    {
                        PayAllDue();
                        bim.Frequency += 1;
                        bim.RemainingSum -= decimal.Parse(ctUnderPay.Text);
                        bim.TotalSpending += decimal.Parse(ctUnderPay.Text);
                        bim.Save();
                        MessageBox.Show("已经完成结算！");
                        InitialPos();
                    }
                    else 
                    {
                        if (bim.RemainingSum + ctRealPay.Value >= decimal.Parse(ctUnderPay.Text))
                        {
                            PayAllDue();
                            bim.RemainingSum = 0;
                            bim.Save();
                            //todo 在这里提示会员是否充值
                            MessageBox.Show("会员余额已经为零，是否要充值？");
                        }
                        else
                        {
                            MessageBox.Show("会员余额不足以支付当前应收金额！");
                        }

                    }
                }
            }

        }

        private void PayAllDue()
        {
            SupplyChainPos scp = SupplyChainPos.FindById(PosId);
            SupplyChainPosDetail scpd;
            //1.遍历表格，取出未付和非赠品，设置为已付
            //2.将pos主表相关项填好，并设为已结
            //3.区分保存储值卡、实付等数据，方便以后统计。
            foreach (DataGridViewRow row in dgvPosDetail.Rows)
            {
                if (row.Selected || (bool)row.Cells["是否已付"].Value == false
                    || (bool)row.Cells["是否退货"].Value == false
                    || (bool)row.Cells["是否赠品"].Value == false)
                {
                    scpd = SupplyChainPosDetail.FindById(long.Parse(row.Cells["Id"].Value.ToString()));
                    scpd.IsPaid = true;
                    scpd.Save();
                    scp.UnPaidQuantity -= 1;
                    scp.UnPayAmount -= scpd.Amount;
                    if (scp.UnPaidQuantity == 0 && scp.UnPayAmount == 0)
                    {
                        scp.IsAllPaid = true;
                    }
                    scp.Save();
                }
            }

            if (decimal.Parse(ctRemainingSum.Text) >= decimal.Parse(ctUnderPay.Text))
            {
                scp.PayByStoredValueCard = decimal.Parse(ctUnderPay.Text);
                scp.Save();
            }
            else if (decimal.Parse(ctRemainingSum.Text) + ctRealPay.Value == decimal.Parse(ctUnderPay.Text))
            {
                scp.PayByStoredValueCard = decimal.Parse(ctUnderPay.Text) - ctRealPay.Value;
                scp.PayInAmount = ctRealPay.Value;
                scp.Save();
            }
            


        }







    }
}
