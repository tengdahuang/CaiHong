using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;
using ChildCafe.Common;

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
        [ChnCol("办卡日期")]
        public abstract DateTime? JoinedDate { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [Length(30),ChnCol("卡号")]
        public abstract string CardNumber { get; set; }

        /// <summary>
        /// 宝宝名
        /// </summary>
        [Length(30),ChnCol("宝宝名")]
        public abstract string ChildName{ get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        [AllowNull, Length(20),ChnCol("简拼")]
        public abstract string PinYin { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [Length(30),ChnCol("手机")]
        public abstract string Mobile { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [Length(30),ChnCol("卡类型")]
        public abstract string CardType { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        [ChnCol("剩余次数")]
        public abstract decimal CountLeft { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        [ChnCol("到期日")]
        public abstract DateTime ExpirationDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(200), ChnCol("备注")]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        [ChnCol("卡状态")]
        public abstract int CardStatus { get; set; }


        [SpecialName, ChnCol("保存日期")]
        public abstract DateTime SavedOn { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [Length(30),ChnCol("用户类型")]
        public abstract string OptrType { get; set; }

        [BelongsTo, DbColumn("BaseInfoCard_Id")]
        public abstract BaseInfoMember BaseInfoMember { get; set; }

    }
}
