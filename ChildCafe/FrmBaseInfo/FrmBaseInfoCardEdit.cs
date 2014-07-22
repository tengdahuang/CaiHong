using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Common;
using ChildCafe.Dal;
using XSolo.Common;

namespace ChildCafe
{
    public partial class FrmBaseInfoCardEdit : XSolo.BaseForm.FrmAddEdit
    {
        private long MemberId = -1;
        public FrmBaseInfoCardEdit()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text += " 按F7选择会员";
        }

        protected override void Loading()
        {

            if (!IsAdd)
            {
                var obj = BaseInfoCard.FindById(long.Parse(ItemID));
                FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
                if (obj.BaseInfoMember != null) { ctMemberCardNumber.Text = obj.BaseInfoMember.CardNumber; }

            }
            else
            {
                ctCountLeft.Value = 10;
                ctJoinedDate.Value = DateTime.Now;
            }

        }

        protected override void Saving()
        {
            if (IsAdd)
            {
                if (MemberId == -1)
                {
                    var obj = BaseInfoCard.New;
                    FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                    obj.OptrType = UserStatics.OptrType;
                    obj.CardStatus = 1;
                    obj.Save();
                }
                else
                {

                    var member = BaseInfoMember.FindById(MemberId);
                    var obj = BaseInfoCard.New;
                    FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                    obj.OptrType = UserStatics.OptrType;
                    obj.CardStatus = 1;
                    obj.Save();
                    member.BaseInfoCards.Add(obj);
                    member.Save();
                }

            }
            else
            {
                if (MemberId == -1)
                {
                    var obj = BaseInfoCard.FindById(long.Parse(ItemID));
                    FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                    obj.OptrType = UserStatics.OptrType;
                    obj.CardStatus = 1;
                    obj.Save();
                }
                else
                {
                    var member = BaseInfoMember.FindById(MemberId);
                    var obj = BaseInfoCard.FindById(long.Parse(ItemID));
                    FrmAddEditBindComboBoxText.BindControlsToObject(obj, tabPage1);
                    obj.OptrType = UserStatics.OptrType;
                    obj.CardStatus = 1;
                    obj.Save();
                    member.BaseInfoCards.Add(obj);
                    member.Save();
                }

            }
        }

        protected override void DefineControlErrors()
        {
            if (ctCardNumber.Text == "") errorProvider.SetError(ctCardNumber, "卡号不能为空");
            else errorProvider.SetError(ctCardNumber, "");
            if (ctChildName.Text == "") errorProvider.SetError(ctChildName, "宝宝名不能为空");
            else errorProvider.SetError(ctChildName, "");
            if (ctMobile.Text == "") errorProvider.SetError(ctMobile, "手机不能为空");
            else errorProvider.SetError(ctMobile, "");
            if (ctCardType.Text == "") errorProvider.SetError(ctCardType, "卡类型不能为空");
            else errorProvider.SetError(ctCardType, "");

            string mobile = ctMobile.Text.Trim();
            if (mobile.Length != 11)
            {
                errorProvider.SetError(ctMobile, "手机长度必须是11位");
                ctMobile.SelectAll();
                ctMobile.Focus();
            }
            else errorProvider.SetError(ctMobile, "");

            if (!System.Text.RegularExpressions.Regex.IsMatch(mobile, @"^((0?1[358]\d{9})|((0(10|2[1-3]|[3-9]\d{2}))?[1-9]\d{6,7}))$"))
            {
                errorProvider.SetError(ctMobile, "手机号格式不正确，并且不能为除数字外的字符！");
                ctMobile.SelectAll();
                ctMobile.Focus();
            }
            else errorProvider.SetError(ctMobile, "");

        }


        protected override void AfterSave()
        {
            this.Close();
        }

        private void ctChildName_TextChanged(object sender, EventArgs e)
        {
            ctPinYin.Text = AutoPinYin.GetPinYin(ctChildName.Text);

        }

        private void PerformClick()
        {
            FrmBaseInfoMember fbim = new FrmBaseInfoMember();
            fbim.IsSelect = true;
            fbim.ShowDialog();
            //返回的SelectedValue,取出SelectedValue的相应数据
            BaseInfoMember bim = BaseInfoMember.FindById(fbim.SelectedValue);
            ctMemberCardNumber.Text = bim.CardNumber;
            MemberId = fbim.SelectedValue;
            fbim.Dispose();
        }

        private void FrmBaseInfoCardEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                PerformClick();
            }
        }

        private void ctCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctCardType.Text == "十次卡") { ctCountLeft.Value = 10; ctExpirationDate.Value = DateTime.Now.AddYears(1); }
            if (ctCardType.Text == "二十次卡") { ctCountLeft.Value = 20; ctExpirationDate.Value = DateTime.Now.AddYears(1); }
            if (ctCardType.Text == "月卡") { ctExpirationDate.Value = DateTime.Now.AddMonths(1); }
            if (ctCardType.Text == "年卡") { ctExpirationDate.Value = DateTime.Now.AddYears(1); }
            if (ctCardType.Text == "暑假卡") { ctExpirationDate.Value = DateTime.Now.AddMonths(2); }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

        }




    }
}
