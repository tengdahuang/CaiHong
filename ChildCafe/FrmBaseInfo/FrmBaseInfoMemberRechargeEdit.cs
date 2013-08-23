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
    public partial class FrmBaseInfoMemberRechargeEdit : XSolo.BaseForm.FrmAddEdit
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public long MemberId { get; set; }

        /// <summary>
        /// 保存第一次载入的会员余额
        /// </summary>
        private decimal remainingSum = 0;

        public FrmBaseInfoMemberRechargeEdit()
        {
            InitializeComponent();
        }

        protected override void Loading()
        {
            var obj = BaseInfoMember.FindById(MemberId);
            FrmAddEditBindComboBoxText.BindObjectToControls(obj, tabPage1);
            ctRechargeDate.Value = DateTime.Now;
            remainingSum = ctRemainingSum.Value;
        }

        private void ctPayValue_ValueChanged(object sender, EventArgs e)
        {
            ctRemainingSum.Value = remainingSum;
            ctRechargeValue.Value = ctPayValue.Value;
            ctRemainingSum.Value = remainingSum + ctRechargeValue.Value;
        }

        private void ctRechargeValue_ValueChanged(object sender, EventArgs e)
        {
            ctRemainingSum.Value = remainingSum;
            ctRemainingSum.Value = remainingSum + ctRechargeValue.Value;
        }

        protected override void Saving()
        {
            if (IsAdd)
            {
                var obj = BaseInfoMember.FindById(MemberId);

                var objRecharge = BaseInfoMemberRecharge.New;
                FrmAddEditBindComboBoxText.BindControlsToObject(objRecharge, tabPage1);
                objRecharge.OptrType = UserStatics.OptrType;
                objRecharge.PayType = "现金";
                objRecharge.Save();

                obj.RemainingSum = ctRemainingSum.Value;
                obj.BaseInfoMemberRecharges.Add(objRecharge);
                obj.Save();

            }

        }

        protected override void AfterSave()
        {
            this.Close();
        }
    }
}
