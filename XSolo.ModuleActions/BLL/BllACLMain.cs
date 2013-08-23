using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lephone.Data;
using Lephone.Data.Definition;
using XSolo.ModuleActions.DataAccess;
using XSolo.Common;

namespace XSolo.ModuleActions.BLL
{
    public class BllACLMain
    {
        //public static DataTable GetMenuTable()
        //{
        //    DataSet ds = DbEntry.Context.ExecuteDataset("Select * from MainModule");
        //    var dt = ds.Tables[0];
        //    return dt;
        //}


        /// <summary>
        ///  取得该用户有权限的模块
        /// </summary>
        /// <param name="id">当前用户ID</param>
        /// <returns>返回表格</returns>
        public static DataTable GetAccessModules()
        {
            //DataSet ds = DbEntry.Context.ExecuteDataset("SP_GetUserAccessModules", id);
            return DbEntry.Context.ExecuteDataset("Select * from MainModule where Status in (0,9)").Tables[0];

        }

        /// <summary>
        /// 判断是否有子目录
        /// </summary>
        /// <param name="id">目录id</param>
        /// <returns>是否有子目录</returns>
        public static bool CheckIfHasChildren(long id)
        {
            int result = MainModule.Find(CK.K["ParentId"] == id).Count;
            if(result != 0)
                return true;
            return false;
        }
    }
}
