using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class SupplyChainPosDetail:DbObjectModel<SupplyChainPosDetail>
    {
        [BelongsTo, DbColumn("SupplyChainPosId")]
        public abstract SupplyChainPos SupplyChainPos { get; set; }

        /// <summary>
        /// 是否已付
        /// </summary>
        public abstract bool IsPaid { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public abstract long MaterialId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Length(30)]
        public abstract string MaterialName { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [Length(30)]
        public abstract string MaterialCategory { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [AllowNull, Length(10)]
        public abstract string UnitName { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public abstract decimal UnitPrice { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public abstract decimal Quantity { get; set; }

        /// <summary>
        /// 打折比例
        /// </summary>
        public abstract decimal Discount { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public abstract decimal Amount { get; set; }

        /// <summary>
        /// 是否退货
        /// </summary>
        public abstract bool IsReturns { get; set; }

        /// <summary>
        /// 是否赠菜
        /// </summary>
        public abstract bool IsGift { get; set; }

        /// <summary>
        /// 点菜时间
        /// </summary>
        public abstract DateTime OrderDateTime { get; set; }

    }
}
