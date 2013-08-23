using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    public abstract class TechnologicalEquipment: DbObjectModel<TechnologicalEquipment>
    {
        /// <summary>
        /// 机台号
        /// </summary>
        [Length(50)]
        public abstract string EquipmentNo { get; set; }

        /// <summary>
        /// 模具号
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Model { get; set; }

        /// <summary>
        /// 工装编号
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string TeNo { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string ProductType { get; set; }

        /// <summary>
        /// 工装类型
        /// </summary>
        [Length(50)]
        public abstract string TechnologicalEquipmentType { get; set; }

        /// <summary>
        /// 工装状态
        /// </summary>
        public abstract int TechnologicalEquipmentStatus { get; set; }

        /// <summary>
        /// 安装日期
        /// </summary>
        public abstract DateTime InstallDate { get; set; }

        /// <summary>
        /// 安装者
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string WhoInstalled { get; set; }

        /// <summary>
        /// 原始寿命
        /// </summary>
        public abstract int ElderCount { get; set; }

        /// <summary>
        /// 寿命下限
        /// </summary>
        public abstract int LowerLimitCount { get; set; }

        /// <summary>
        /// 寿命上限
        /// </summary>
        public abstract int UpperLimitCount { get; set; }

        /// <summary>
        /// 拆卸日期
        /// </summary>
        public abstract DateTime? UninstallDate { get; set; }

        /// <summary>
        /// 使用寿命
        /// </summary>
        public abstract int UseCount { get; set; }

        /// <summary>
        /// 拆卸原因
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string UninstallReason { get; set; }

        /// <summary>
        /// 拆卸者
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string WhoUninstalled { get; set; }

        /// <summary>
        /// 工装处理
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string TeHandle { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Supplier { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [Length(50)]
        public abstract string OptrType { get; set; }

        /// <summary>
        /// 保存日期
        /// </summary>
        [SpecialName]
        public abstract DateTime SavedOn { get; set; }
    }
}
