using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class BaseInfoStaff: DbObjectModel<BaseInfoStaff>
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Length(30)]
        public abstract string Number { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Length(30)]
        public abstract string Name { get; set; }

        /// <summary>
        /// 简拼
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string ShortCode { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string Sex { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string Level { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string QQ { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string Phone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string Address { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [Length(30)]
        public abstract string IdCard { get; set; }

        /// <summary>
        /// 入职日期
        /// </summary>
        public abstract DateTime DateOfEmployment { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull, Length(100)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(30)]
        public abstract string OptrType { get; set; }

        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

    }
}
