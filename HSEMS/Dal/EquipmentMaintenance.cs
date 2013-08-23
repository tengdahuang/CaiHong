using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    public abstract class EquipmentMaintenance: DbObjectModel<EquipmentMaintenance>
    {
        /// <summary>
        /// 机台号
        /// </summary>
        [Length(50)]
        public abstract string EquipmentNo { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string Process { get; set; }

        /// <summary>
        /// 测试系统
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string TestSystem { get; set; }

        /// <summary>
        /// 模具号
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string ModeNo { get; set; }

        /// <summary>
        /// 测试仪
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Tester { get; set; }

        /// <summary>
        /// 品种
        /// </summary>
        [Length(50)]
        public abstract string ProductClass { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        [Length(50)]
        public abstract string LotNo { get; set; }

        /// <summary>
        /// 报修人
        /// </summary>
        [Length(50)]
        public abstract string WhoNotice { get; set; }

        /// <summary>
        /// 报修日期
        /// </summary>
        public abstract DateTime NoticeDate { get; set; }

        /// <summary>
        /// 管理分类
        /// </summary>
        [Length(50)]
        public abstract string ManagementType { get; set; }

        /// <summary>
        /// 故障现象
        /// </summary>
        [Length(100)]
        public abstract string FailurePhenomenon { get; set; }



        /// <summary>
        /// 接单日期
        /// </summary>
        public abstract DateTime? AcceptDate { get; set; }

        /// <summary>
        /// 接单人
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Accepter1 { get; set; }



        /// <summary>
        /// 故障确认
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string FailureIdentification { get; set; }

        /// <summary>
        /// 原因分析
        /// </summary>
        [AllowNull, Length(600)]
        public abstract string CausalAnalysis { get; set; }

        /// <summary>
        /// 维修内容
        /// </summary>
        [AllowNull, Length(600)]
        public abstract string RepairContent { get; set; }

        /// <summary>
        /// 效果确认
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string ResultConfirm { get; set; }

        /// <summary>
        /// 故障分类
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string FailureType { get; set; }

        /// <summary>
        /// 产品处理
        /// </summary>
        [ AllowNull, Length(50)]
        public abstract string ProductHandle { get; set; }

        /// <summary>
        /// 修复日期1
        /// </summary>
        public abstract DateTime? RestoreDate1 { get; set; }

        /// <summary>
        /// 协助人员1
        /// </summary>
        [ AllowNull, Length(50)]
        public abstract string Assist1 { get; set; }

        /// <summary>
        /// 当班班长1
        /// </summary>
        [ AllowNull, Length(50)]
        public abstract string Monitor1 { get; set; }

        /// <summary>
        /// 更换备件1
        /// </summary>
        [ AllowNull, Length(100)]
        public abstract string SpareParts1 { get; set; }

        /// <summary>
        /// 遗留问题
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string RemainingProblem { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(500)]
        public abstract string Remark { get; set; }



        /// <summary>
        /// 修复者2
        /// </summary>
        [ AllowNull, Length(50)]
        public abstract string Accepter2 { get; set; }

        /// <summary>
        /// 协助人员2
        /// </summary>
        [ AllowNull, Length(50)]
        public abstract string Assist2 { get; set; }

        /// <summary>
        /// 当班班长2
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Monitor2 { get; set; }

        /// <summary>
        /// 更换备件2
        /// </summary>
        [ AllowNull, Length(100)]
        public abstract string SparePart2 { get; set; }

        /// <summary>
        /// 修复日期2
        /// </summary>
        public abstract DateTime? RestoreDate2 { get; set; }



        /// <summary>
        /// 处理确认
        /// </summary>
        [ AllowNull, Length(50)]
        public abstract string ProductHandledConfirm { get; set; }

        /// <summary>
        /// 复测机台
        /// </summary>
        [ AllowNull, Length(50)]
        public abstract string RetestEquipment { get; set; }

        /// <summary>
        /// 处理者
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string WhoHandled { get; set; }

        /// <summary>
        /// 处理日期1
        /// </summary>
        public abstract DateTime? HandleDate { get; set; }

        /// <summary>
        /// 已隔离
        /// </summary>
        public abstract bool IsIsolated { get; set; }



        /// <summary>
        /// 问题处理
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string RemainingProblemResult { get; set; }

        /// <summary>
        /// 处理日期2
        /// </summary>
        public abstract DateTime? RemainingProblemHandleDate { get; set; }



        /// <summary>
        /// 用户类型
        /// </summary>
        [ Length(50)]
        public abstract string OptrType { get; set; }

        /// <summary>
        /// 流程状态
        /// </summary>
        [ Length(20)]
        public abstract string Status { get; set; }

        /// <summary>
        /// 待修耗时
        /// </summary>
        public abstract double WaitingTakes { get; set; }

        /// <summary>
        /// 故障耗时1
        /// </summary>
        public abstract double RepairingTakes1 { get; set; }

        /// <summary>
        /// 故障耗时2
        /// </summary>
        public abstract double RepairingTakes2{ get; set; }
    }
}
