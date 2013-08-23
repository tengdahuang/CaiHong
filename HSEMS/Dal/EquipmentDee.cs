using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    public abstract class EquipmentDee: DbObjectModel<EquipmentDee>
    {
        /// <summary>
        /// 机台号
        /// </summary>
        [Length(50)]
        public abstract string EquipmentNo { get; set; }

        /// <summary>
        /// 模具号
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string Model { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public abstract DateTime DeeDate { get; set; }

        /// <summary>
        /// 班组
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Grouping { get; set; }

        /// <summary>
        /// 组长
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string GroupMonitor { get; set; }

        /// <summary>
        /// 维修班长
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string RepairMonitor { get; set; }

        /// <summary>
        /// 操作工
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Operator { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string Process { get; set; }

        /// <summary>
        /// 当前品种
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string CurrentProduct { get; set; }


        /// <summary>
        /// 实际产量
        /// </summary>
        public abstract int ActualOutput { get; set; }

        /// <summary>
        /// 复测产量/折算产量
        /// </summary>
        public abstract int ConvertionOutput { get; set; }

        /// <summary>
        /// 停产耗时
        /// </summary>
        public abstract int StopTime { get; set; }

        /// <summary>
        /// 故障次数
        /// </summary>
        public abstract int FaultTimes { get; set; }

        /// <summary>
        /// 故障耗时
        /// </summary>
        public abstract int FaultTakes { get; set; }

        /// <summary>
        /// 待料
        /// </summary>
        public abstract int DownTime { get; set; }

        /// <summary>
        /// 试验
        /// </summary>
        public abstract int Test { get; set; }

        /// <summary>
        /// QA
        /// </summary>
        public abstract int Qa { get; set; }

        /// <summary>
        /// 更换次数
        /// </summary>
        public abstract int ChangeTimes { get; set; }

        /// <summary>
        /// 更换耗时
        /// </summary>
        public abstract int ChangeTakes { get; set; }

        /// <summary>
        /// 清模
        /// </summary>
        public abstract int ClearModel { get; set; }

        /// <summary>
        /// PM
        /// </summary>
        public abstract int PM { get; set; }

        /// <summary>
        /// 减产原因
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Reason { get; set; }

        /// <summary>
        /// 适应产品
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string ProductAdaptation { get; set; }

        /// <summary>
        /// 统计分类
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string StatisticalClass { get; set; }

        /// <summary>
        /// UPH
        /// </summary>
        public abstract int UnitsPerHour { get; set; }

        /// <summary>
        /// 定额
        /// </summary>
        public abstract int ProductionQuota { get; set; }

        /// <summary>
        /// 管理分组
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string ManagementGroup { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [Length(50)]
        public abstract string OptrType { get; set; }
    }
}
