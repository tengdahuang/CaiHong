using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    public abstract class EquipmentOffline: DbObjectModel<EquipmentOffline>
    {
        /// <summary>
        /// 机台号
        /// </summary>
        [Length(50)]
        public abstract string EquipmentNo { get; set; }

        /// <summary>
        /// 设备分类(分类/测试)
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string EquipmentType { get; set; }

        /// <summary>
        /// 离线原因
        /// </summary>
        [Length(200)]
        public abstract string OfflineReason { get; set; }

        /// <summary>
        /// 提交人
        /// </summary>
        [Length(50)]
        public abstract string WhoApplied { get; set; }

        /// <summary>
        /// 离线日期(非空日期必须先初始化)
        /// </summary>
        public abstract DateTime OfflineDate { get; set; }
        
        /// <summary>
        /// 维修记录
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string OfflineRepairRecord { get; set; }

        /// <summary>
        /// 效果确认
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string OfflineResultConfirm { get; set; }

        /// <summary>
        /// 修复人
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string OfflineWhoRepaired { get; set; }

        /// <summary>
        /// 修复日期(非空日期必须先初始化)
        /// </summary>
        public abstract DateTime OfflineRepairDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(500)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(50)]
        public abstract string OptrType { get; set; }

    }
}
