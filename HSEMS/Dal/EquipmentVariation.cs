using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    public abstract class EquipmentVariation : DbObjectModel<EquipmentVariation>
    {
        /// <summary>
        /// 变更类别
        /// </summary>
        [Length(50)]
        public abstract string VariationType { get; set; }

        /// <summary>
        /// 变更原因
        /// </summary>
        [Length(50)]
        public abstract string VariationReason { get; set; }

        /// <summary>
        /// 机台号
        /// </summary>
        [Length(50)]
        public abstract string EquipmentNo { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Process { get; set; }

        /// <summary>
        /// 变更前
        /// </summary>
        [Length(50)]
        public abstract string BeforeVariation { get; set; }

        /// <summary>
        /// 变更后
        /// </summary>
        [Length(50)]
        public abstract string AfterVariation { get; set; }

        /// <summary>
        /// 安排人
        /// </summary>
        [Length(50)]
        public abstract string Distributor { get; set; }

        /// <summary>
        /// 安排时间
        /// </summary>
        public abstract DateTime DistributeDate { get; set; }




        /// <summary>
        /// 接单时间
        /// </summary>
        public abstract DateTime? AcceptDate { get; set; }

        /// <summary>
        /// 接单维修
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Accepter1 { get; set; }







        /// <summary>
        /// 协助人员
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Assist { get; set; }


        /// <summary>
        /// 搬动测试仪
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Tester { get; set; }

        /// <summary>
        /// 处理内容1
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string VariationContent1 { get; set; }

        /// <summary>
        /// 效果确认
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string ResultConfirm { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public abstract DateTime? FinishDate1 { get; set; }

        /// <summary>
        /// 更换备件
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string SpareParts { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(500)]
        public abstract string Remark { get; set; }




        /// <summary>
        /// 最后处理
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string VariationContent2 { get; set; }

        /// <summary>
        /// 处理者2
        /// </summary>
        [AllowNull, Length(50)]
        public abstract string Accepter2 { get; set; }

        /// <summary>
        /// 完成日期2
        /// </summary>
        public abstract DateTime? FinishDate2 { get; set; }





        /// <summary>
        /// 用户类型
        /// </summary>
        [Length(50)]
        public abstract string OptrType { get; set; }

        /// <summary>
        /// 流程状态
        /// </summary>
        [Length(20)]
        public abstract string Status { get; set; }

        /// <summary>
        /// 待换耗时
        /// </summary>
        public abstract double WaitingTakes { get; set; }

        /// <summary>
        /// 更换耗时1
        /// </summary>
        public abstract double VariationTakes1 { get; set; }

        /// <summary>
        /// 更换耗时2
        /// </summary>
        public abstract double VariationTakes2 { get; set; }
    }
}
