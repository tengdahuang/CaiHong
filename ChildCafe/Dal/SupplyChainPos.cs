using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class SupplyChainPos: DbObjectModel<SupplyChainPos>
    {
        /// <summary>
        /// 桌号
        /// </summary>
        [AllowNull,Length(30)]
        public abstract string TableNo { get; set; }

        public abstract long? MemberId { get; set; }

        /// <summary>
        /// 收银日期
        /// </summary>
        public abstract DateTime PosDateTime { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [Length(30)]
        public abstract string SerialNumber { get; set; }

        /// <summary>
        /// 收银员
        /// </summary>
        [Length(30)]
        public abstract string Cashier { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        public abstract decimal Quantity { get; set; }

        /// <summary>
        /// 已收数量
        /// </summary>
        public abstract decimal PaidQuantity { get; set; }

        /// <summary>
        /// 未收数量
        /// </summary>
        public abstract decimal UnPaidQuantity { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public abstract decimal PosAmount { get; set; }

        /// <summary>
        /// 实收
        /// </summary>
        public abstract decimal PayInAmount { get; set; }

        /// <summary>
        /// 储值卡
        /// </summary>
        public abstract decimal PayByStoredValueCard { get; set; }

        /// <summary>
        /// 现金
        /// </summary>
        public abstract decimal PayByCash { get; set; }

        /// <summary>
        /// 代金券
        /// </summary>
        public abstract decimal PayByCoupons { get; set; }

        /// <summary>
        /// 银行卡
        /// </summary>
        public abstract decimal PayByBank { get; set; }

        /// <summary>
        /// 本单利润
        /// </summary>
        public abstract decimal PosProfit { get; set; }

        /// <summary>
        /// 是否已结完
        /// </summary>
        public abstract bool IsAllPaid { get; set; }

        /// <summary>
        /// 是否已挂单
        /// </summary>
        public abstract bool IsHolded { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string Remark { get; set; }

        [HasMany(OrderBy = "Id")]
        public abstract IList<SupplyChainPosDetail> SupplyChainPosDetails { get; set; }

    }
}
