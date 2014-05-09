using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public enum BaseInfoCardType
    {
        十次卡=1,
        二十次卡,
        月卡,
        年卡,
        暑假卡
    }

    public enum BaseInfoCardStatus
    {
        使用=1,
        过期,
        作废,
    }

    [SoftDelete]
    public abstract class BaseInfoCard : DbObjectModel<BaseInfoCard>
    {
        /// <summary>
        /// 办卡日期
        /// </summary>
        public abstract DateTime? JoinedDate { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [Length(30)]
        public abstract string CardNumber { get; set; }

        /// <summary>
        /// 宝宝名
        /// </summary>
        [Length(30)]
        public abstract string ChildName{ get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string PinYin { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [Length(30)]
        public abstract string Mobile { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [Length(30)]
        public abstract string CardType { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        public abstract decimal CountLeft { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        public abstract DateTime ExpirationDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        public abstract int CardStatus { get; set; }


        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(30)]
        public abstract string OptrType { get; set; }

        [BelongsTo, DbColumn("BaseInfoCard_Id")]
        public abstract BaseInfoMember BaseInfoMember { get; set; }

    }
}
