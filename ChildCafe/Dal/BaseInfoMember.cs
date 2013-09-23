using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    [SoftDelete]
    public abstract class BaseInfoMember : DbObjectModel<BaseInfoMember>
    {
        /// <summary>
        /// 开卡日期
        /// </summary>
        public abstract DateTime? JoinedDate { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [Length(30)]
        public abstract string CardNumber { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Length(30)]
        public abstract string Name { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string PinYin { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [AllowNull,Length(30)]
        public abstract string Password { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public abstract DateTime Birth { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [AllowNull,Length(30)]
        public abstract string Mobile { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string Phone { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        public abstract decimal DiscountRate { get; set; }

        /// <summary>
        /// 会员余额
        /// </summary>
        public abstract decimal RemainingSum { get; set; }

        /// <summary>
        /// 会员积分
        /// </summary>
        public abstract decimal TotalBonusPoint { get; set; }

        /// <summary>
        /// 消费次数
        /// </summary>
        public abstract decimal Frequency { get; set; }

        /// <summary>
        /// 消费总额
        /// </summary>
        public abstract decimal TotalSpending { get; set; }

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

        [HasMany(OrderBy = "Id")]
        public abstract IList<BaseInfoMemberRecharge> BaseInfoMemberRecharges { get; set; }

        [HasMany(OrderBy = "Id")]
        public abstract IList<SupplyChainPos> SupplyChainPoses { get; set; }
    }
}
