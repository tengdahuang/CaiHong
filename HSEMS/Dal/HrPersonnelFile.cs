using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;
namespace HSEMS.Dal
{
    [SoftDelete]
    public abstract class HrPersonnelFile: DbObjectModel<HrPersonnelFile>
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [Length(20)]
        public abstract string CardNumber { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Length(100)]
        public abstract string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Length(20)]
        public abstract string Sex { get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string Marries { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public abstract DateTime Birthday { get; set; }
        
        /// <summary>
        /// 籍贯
        /// </summary>
        [Length(20)]
        public abstract string Hometown { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string IdentificationCard { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public abstract DateTime DateEmployed { get; set; }

        /// <summary>
        /// 车间
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string WorkShop { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string Process { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string Position { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string ProfessionalTitle { get; set; }

        /// <summary>
        /// 工资级别
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string WageGrade { get; set; }

        /// <summary>
        /// 毕业学校
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string GraduatedSchool { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string Major { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [Length(20)]
        public abstract string HighestEducation { get; set; }

        /// <summary>
        /// 外语能力
        /// </summary>
        [AllowNull,Length(100)]
        public abstract string LanguageLevel { get; set; }

        /// <summary>
        /// 计算机能力
        /// </summary>
        [AllowNull,Length(100)]
        public abstract string ComputerLevel { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        [AllowNull,Length(20)]
        public abstract string PoliticalBackground { get; set; }

        /// <summary>
        /// 爱好
        /// </summary>
        [AllowNull,Length(200),LazyLoad]
        public abstract string Hobby { get; set; }

        /// <summary>
        /// 特长
        /// </summary>
        [AllowNull,Length(200),LazyLoad]
        public abstract string Specialty { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [AllowNull,Length(200),LazyLoad]
        public abstract string Address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [AllowNull,Length(50)]
        public abstract string PhoneNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [AllowNull,Length(200),LazyLoad]
        public abstract string Remark { get; set; }

        ///// <summary>
        ///// 年龄
        ///// </summary>
        //[Length(20),LazyLoad]
        //public abstract string Age { get; set; }

        ///// <summary>
        ///// 年龄分类
        ///// </summary>
        //[LazyLoad]
        //public abstract string AgeType { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [Length(50)]
        public abstract string OptrType { get; set; }

        /// <summary>
        /// 在职状态
        /// </summary>
        [Length(20)]
        public abstract string Status { get; set; }
    }
}
