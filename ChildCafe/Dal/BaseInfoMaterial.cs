using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class BaseInfoMaterial: DbObjectModel<BaseInfoMaterial>
    {

        /// <summary>
        /// 商品编码
        /// </summary>
        [Length(30)]
        public abstract string MeterialCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Length(30)]
        public abstract string MaterialName { get; set; }

        /// <summary>
        /// 简码
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string ShortCode { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string Barcode { get; set; }

        /// <summary>
        /// 商品分类
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string Category { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string Specification { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string ItemNo { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string Brand { get; set; }

        /// <summary>
        /// 采购单位
        /// </summary>
        [AllowNull, Length(10)]
        public abstract string PurchaseUnitName { get; set; }

        /// <summary>
        /// 销售单位
        /// </summary>
        [AllowNull, Length(10)]
        public abstract string SaleUnitName { get; set; }

        /// <summary>
        /// 换算率
        /// </summary>
        public abstract decimal UnitConvValue { get; set; }

        /// <summary>
        /// 单位进价
        /// </summary>
        public abstract decimal UnitPrice { get; set; }

        /// <summary>
        /// 换算进价
        /// </summary>
        public abstract decimal ConvPrice { get; set; }

        /// <summary>
        /// 平均进价
        /// </summary>
        public abstract decimal AvgPrice { get; set; }

        /// <summary>
        /// 零售价
        /// </summary>
        public abstract decimal RetailPrice { get; set; }

        /// <summary>
        /// 会员价
        /// </summary>
        public abstract decimal MemberPrice { get; set; }

        /// <summary>
        /// 库存数
        /// </summary>
        public abstract decimal InvQuantity { get; set; }

        /// <summary>
        /// 换算库存数
        /// </summary>
        public abstract decimal ConvQuantity { get; set; }

        /// <summary>
        /// 库存成本
        /// </summary>
        public abstract decimal InventoryCost { get; set; }

        /// <summary>
        /// 报警数
        /// </summary>
        public abstract decimal StockLowAlarm { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        public abstract decimal BonusPoint { get; set; }

        /// <summary>
        /// 是否计入库存
        /// </summary>
        public abstract bool IsAddToInventory { get; set; }

        /// <summary>
        /// 是否半成品
        /// </summary>
        public abstract bool IsIngredient { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Length(30)]
        public abstract string Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Length(50)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(30)]
        public abstract string OptrType { get; set; }

        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        [HasMany(OrderBy = "Id")]
        public abstract IList<BaseInfoMaterialIngredient> BaseInfoMaterialIngredients { get; set; }

    }
}
