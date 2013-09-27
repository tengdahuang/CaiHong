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

        public FrmSupplyChainPos()
        {
            InitializeComponent();
        }

        private void FrmSupplyChainPos_Load(object sender, EventArgs e)
        {
            //1.取出最新的流水号，新增并保存一张未结算pos单
            SupplyChainPos fscp = SupplyChainPos.New;
            fscp.SerialNumber = BllSupplyChainPos.GetPosSN();
            //fscp.SerialNumber = "00000000000";
            fscp.PosDateTime = DateTime.Now;
            fscp.Cashier = UserStatics.ChineseName;
            fscp.Quantity = 0;
            fscp.PaidQuantity = 0;
            fscp.UnPaidQuantity = 0;
            fscp.PosAmount = 0;
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


        }

        private void FrmSupplyChainPos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ctMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                RaiseMemberSearchWindow();
            }

        }

        private void ctMember_Click(object sender, EventArgs e)
        {
            RaiseMemberSearchWindow();
        }

        private void RaiseMemberSearchWindow()
        {
            //FrmEquipmentInformation fei = new FrmEquipmentInformation(); ;
            //fei.IsSelect = true;
            //fei.ShowDialog();
            ////返回的SelectedValue,取出SelectedValue的EquipmentInformation
            //EquipmentInformation ei = EquipmentInformation.FindById(fei.SelectedValue);
            ////绑定各个控件
            //FrmAddEditBindComboBoxText.BindObjectToControls(ei, tabPage1);
            //fei.Dispose();
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




    }
}
