using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    [SoftDelete]
    public abstract class EquipmentInformation: DbObjectModel<EquipmentInformation>
    {

        /// <summary>
        /// 设备分类(分类/测试)
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string EquipmentType { get; set; }

        /// <summary>
        /// 机台号
        /// </summary>
        [Length(50)]
        public abstract string EquipmentNo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [Length(50)]
        public abstract string Model { get; set; }

        /// <summary>
        /// 适应产品(分类)
        /// </summary>
        [Length(50)]
        public abstract string ProductAdaptation { get; set; }

        /// <summary>
        /// 单位产量
        /// </summary>
        public abstract int UnitsPerHour { get; set; }

        /// <summary>
        /// 班产定额
        /// </summary>
        public abstract int ProductionQuota { get; set; }
        
        /// <summary>
        /// 使用状态(分类)
        /// </summary>
        [Length(50)]
        public abstract string Condition { get; set; }

        /// <summary>
        /// 管理分组(测试)
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string ManagementGroup { get; set; }

        /// <summary>
        /// 设备分级(测试)
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string DeviceClass { get; set; }

        /// <summary>
        /// 测试站(测试)
        /// </summary>
        public abstract int TestStation { get; set; }

        /// <summary>
        /// 通道数(测试)
        /// </summary>
        public abstract int ChannelCount { get; set; }

        /// <summary>
        /// 制造厂家
        /// </summary>
        [Length(50)]
        public abstract string Manufacturer { get; set; }

        /// <summary>
        /// 制造时间
        /// </summary>
        public abstract DateTime? ManufacturingDate { get; set; }

        /// <summary>
        /// 进厂时间
        /// </summary>
        public abstract DateTime? PurchaseDate { get; set; }

        /// <summary>
        /// 生产适应性
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string Adaptability { get; set; }

        /// <summary>
        /// 统计分类(分类)
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string StatisticalClass { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string Process { get; set; }

        /// <summary>
        /// 模具号(封装)
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string ModeNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull,Length(500)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(50)]
        public abstract string OptrType { get; set; }

    }
}
