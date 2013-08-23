using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;
using XSolo.Common;

namespace HSEMS.Bll
{
    public class BllFrmAppMain
    {

        /// <summary>
        ///  取得该用户有权限的模块
        /// </summary>
        /// <param name="id">当前用户ID</param>
        /// <returns>返回表格</returns>
        public static DataTable GetUserAccessModules(long id)
        {
            return DbEntry.Context.ExecuteDataset("SP_GetUserAccessModules", id).Tables[0];

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
