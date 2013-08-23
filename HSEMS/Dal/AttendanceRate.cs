using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    public abstract class AttendanceRate : DbObjectModel<AttendanceRate>
    {
        /// <summary>
        /// 日期
        /// </summary>
        public abstract DateTime InputDate { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [Length(50)]
        public abstract string District { get; set; }

        /// <summary>
        /// 组长
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string GroupMonitor { get; set; }

        /// <summary>
        /// 管理人员
        /// </summary>
        public abstract decimal ManagementPerson { get; set; }

        /// <summary>
        /// 技术人员
        /// </summary>
        public abstract decimal TechnicalPerson { get; set; }

        /// <summary>
        /// 辅助人员
        /// </summary>
        public abstract decimal AuxiliaryPerson { get; set; }

        /// <summary>
        /// 大功率操作工
        /// </summary>
        public abstract decimal HighPowerOperator { get; set; }

        /// <summary>
        /// 小功率操作工
        /// </summary>
        public abstract decimal LowPowerOperator { get; set; }

        /// <summary>
        /// 新工
        /// </summary>
        public abstract decimal NewOperator { get; set; }

        /// <summary>
        /// 缺勤
        /// </summary>
        public abstract decimal AbsencePerson { get; set; }

        /// <summary>
        /// 大功率测试产量
        /// </summary>
        public abstract decimal HighPowerTestOutput { get; set; }

        /// <summary>
        /// 小功率测试产量
        /// </summary>
        public abstract decimal LowPowerTestOutput { get; set; }

        /// <summary>
        /// 小功率打印产量
        /// </summary>
        public abstract decimal LowPowerPrintOutput { get; set; }

        /// <summary>
        /// 编带产量
        /// </summary>
        public abstract decimal BraidingOutput { get; set; }

        /// <summary>
        /// 包装全检产量
        /// </summary>
        public abstract decimal PackageFullInspectionOutput { get; set; }

        /// <summary>
        /// 包装合批产量
        /// </summary>
        public abstract decimal PackageCombineOutput { get; set; }

        /// <summary>
        /// 大功率交库
        /// </summary>
        public abstract decimal HighPowerDelivery{ get; set; }

        /// <summary>
        /// 大功率委托
        /// </summary>
        public abstract decimal HighPowerOrder { get; set; }

        /// <summary>
        /// 中功率交库
        /// </summary>
        public abstract decimal MidPowerDelivery { get; set; }

        /// <summary>
        /// 中功率委托
        /// </summary>
        public abstract decimal MidPowerOrder { get; set; }

        /// <summary>
        /// 小功率交库
        /// </summary>
        public abstract decimal LowPowerDelivery { get; set; }

        /// <summary>
        /// 小功率委托
        /// </summary>
        public abstract decimal LowPowerOrder { get; set; }

        /// <summary>
        /// 异常用人
        /// </summary>
        public abstract decimal AbnormalPerson { get; set; }

        /// <summary>
        /// 异常原因
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string AbnormalReason { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(500)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [Length(50)]
        public abstract string OptrType { get; set; }
    }
}
