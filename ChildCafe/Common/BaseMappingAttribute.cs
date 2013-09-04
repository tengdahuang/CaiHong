using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ChildCafe.Common
{
    ///<summary>     
    /// 自定义特性 属性或者类可用  支持继承     
    ///</summary>    
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, Inherited = true)]
    public class BaseMappingAttribute : Attribute
    {
        ///<summary>         
        /// 实体实际对应的表名         
        /// </summary>        
        public string TableName { get; set; }

        ///<summary>         
        /// 中文列名         
        /// </summary>        
        public string ColumnName { get; set; }

    }


    ///<summary>     
    /// 会员 ，实际的表名叫MemberInfo，并不是和实体名一致     
    /// </summary>    
    [BaseMapping(TableName = "MemberInfo")]
    public class Member
    {
        private int id;
        [BaseMapping(ColumnName = "关键字")]
        public int Id { get { return id; } set { id = value; } }
        private string userName;
        [BaseMapping(ColumnName = "会员注册名")]
        public string UserName { get { return userName; } set { userName = value; } }
        private string realName;
        [BaseMapping(ColumnName = "会员真实名")]
        public string RealName { get { return realName; } set { realName = value; } }
        private bool isActive;
        ///<summary>         
        /// 是否活跃  没有附加自定义属性         
        /// </summary>        
        public bool IsActive { get { return isActive; } set { isActive = value; } }
    }

    class Program     
    {         
        ///<summary>         
        /// 通过反射取自定义属性         
        /// </summary>         
        /// <typeparam name="T"></typeparam>        
        private static void DisplaySelfAttribute<T>() where T:class ,new() 
        { 
            string tableName =string.Empty;
            List<string> listColumnName =new List<string>();
            Type objType =typeof(T); 
            //取属性上的自定义特性
            foreach (PropertyInfo propInfo in objType.GetProperties())
            {
                object[] objAttrs = propInfo.GetCustomAttributes(typeof(BaseMappingAttribute), true);
                if (objAttrs.Length>0) 
                {
                    BaseMappingAttribute attr = objAttrs[0] as BaseMappingAttribute;
                    if (attr !=null)
                    {
                        listColumnName.Add(attr.ColumnName); 
                        //列名
                    } 
                }  
            }
            //取类上的自定义特性
            object[] objs = objType.GetCustomAttributes(typeof(BaseMappingAttribute), true); 
            foreach (object obj in objs) 
            {
                BaseMappingAttribute attr = obj as BaseMappingAttribute;
                if (attr !=null)
                {
                    tableName = attr.TableName;//表名只有获取一次
                    break;
                }
            }
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = objType.Name;
            } 
            Console.WriteLine(string.Format("The tablename of the entity is:{0} ", tableName));
            if (listColumnName.Count > 0)
            {
                Console.WriteLine("The columns of the table are as follows:");
                foreach (string item in listColumnName)
                {
                    Console.WriteLine(item);
                }
            } 
        }
        //static void Main(string[] args)
        //{
        //    DisplaySelfAttribute<Member>(); //显示结果
        //    Console.ReadLine();
        //}
    }

}