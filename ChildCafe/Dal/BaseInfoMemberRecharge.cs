using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class BaseInfoMemberRecharge : DbObjectModel<BaseInfoMemberRecharge>
    {
        /// <summary>
        /// 流水号
        /// </summary>
        [Length(30)]
        public abstract string SerialNumber { get; set; }

        /// <summary>
        /// 充值日期
        /// </summary>
        public abstract DateTime RechargeDate { get; set; }

        [BelongsTo, DbColumn("BaseInfoMember_Id")]
        public abstract BaseInfoMember BaseInfoMember { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [Length(30)]
        public abstract string PayType { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public abstract decimal PayValue { get; set; }

        /// <summary>
        /// 充值金额
        /// </summary>
        public abstract decimal RechargeValue { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string Description { get; set; }

        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(30)]
        public abstract string OptrType { get; set; }
    }
}
