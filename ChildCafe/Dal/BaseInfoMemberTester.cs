using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    [SoftDelete]
    public abstract class BaseInfoMemberTester: DbObjectModel<BaseInfoMemberTester>
    {
        /// <summary>
        /// 手机
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Length(30)]
        public abstract string Name { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string PinYin { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(200)]
        public abstract string Description { get; set; }
       
        /// <summary>
        /// 开卡日期
        /// </summary>
        public abstract DateTime TestDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public abstract DateTime FinishedDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Length(30)]
        public abstract string Status { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(30)]
        public abstract string OptrType { get; set; }
    }
}
