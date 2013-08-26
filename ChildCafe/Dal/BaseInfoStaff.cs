using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class BaseInfoStaff: DbObjectModel<BaseInfoStaff>
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Length(30)]
        public abstract string StaffName { get; set; }

        /// <summary>
        /// 简码
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string ShortCode { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Length(30)]
        public abstract string Sex { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [Length(30)]
        public abstract string Level { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        [Length(30)]
        public abstract string QQ { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Length(30)]
        public abstract string Phone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Length(30)]
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
        [Length(30)]
        public abstract string Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Length(50)]
        public abstract string Remark { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(30)]
        public abstract string OptrType { get; set; }
    }
}
