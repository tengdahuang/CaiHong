using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{

    public abstract class BaseInfoVendor:DbObjectModel<BaseInfoVendor>
    {
        /// <summary>
        /// 供应商名称
        /// </summary>
        [Length(30)]
        public abstract string Name { get; set; }

        /// <summary>
        /// 简码
        /// </summary>
        [AllowNull, Length(20)]
        public abstract string ShortCode { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [AllowNull, Length(30)]
        public abstract string ContactPerson { get; set; }

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
