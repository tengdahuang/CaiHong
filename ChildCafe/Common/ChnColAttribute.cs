using Lephone.Data.Definition;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace ChildCafe.Common
{
    ///<summary>     
    /// 自定义特性 属性可用  支持继承     
    ///</summary>    
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class ChnColAttribute : Attribute
    {
        public string ChnCol { get; set; }

        public ChnColAttribute(string chncol)
        {
            this.ChnCol = chncol;
        }
    }

    public class ChineseColumnName<T>
    {

        public static List<string> GetListColumnNames<T>()
        {

            //得到当前类型
            Type type = typeof(T);
            //得到所有属性
            PropertyInfo[] properties = type.GetProperties();
            List<string> columns = new List<string>();
            //遍历属性，并反射出各属性的“注释”，将“注释”命名为列名（通常是中文的）
            columns.Add("Id,Id");
            foreach (PropertyInfo pi in properties)
            {
                //反射，得到当前属性的“注释”
                ChnColAttribute cca = (ChnColAttribute)Attribute.GetCustomAttribute(pi, typeof(ChnColAttribute));
                BelongsToAttribute bta = (BelongsToAttribute)Attribute.GetCustomAttribute(pi, typeof(BelongsToAttribute));
                //判断“注释”是否为空
                string s = string.Empty;
                if (cca != null)
                    columns.Add(cca.ChnCol + "," + pi.Name);  //向集合中添加当前属性的“注释”（中文的）
                else if (bta != null)
                    columns.Add(pi.Name + "_Id" + "," + pi.Name +"_Id");
                //else
                //    throw new Exception("请为对象的所有属性加上\"注释\"\r\n\r\n示例：[Description(\"注释内容\")]");
            }

            return columns;

        }

        public static DataTable SetColumn(DataTable dt)
        {
            foreach (DataColumn dc in dt.Columns)
            {
                foreach (string s in ChineseColumnName<T>.GetListColumnNames<T>())
                {
                    if (dc.Caption == s.Split(',')[1].ToString())
                    {
                        dc.ColumnName = s.Split(',')[0].ToString();
                    }
                }
            }
            return dt;
        }


    }
}
