using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class BaseInfoMaterialIngredient: DbObjectModel<BaseInfoMaterialIngredient>
    {
        [BelongsTo, DbColumn("BaseInfoMaterial_Id")]
        public abstract BaseInfoMaterial BaseInfoMaterial { get; set; }

        /// <summary>
        /// 半成品Id
        /// </summary>
        public abstract long IngredientId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Length(30)]
        public abstract string MaterialName { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public abstract decimal Price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public abstract decimal Quantity { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        public abstract decimal Cost { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(30)]
        public abstract string OptrType { get; set; }

        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

    }
}
