using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;
using XSolo.Common;

namespace ChildCafe.Bll
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
            DataTable dt = new DataTable();
            SqlStatement sqlStatement =
            new SqlStatement("SELECT mm.Id AS Id, mm.Name AS Name, mm.ChineseName AS ChineseName, mm.ParentId AS ParentId, mm.Sequence AS Sequence " +
                                "from " + 
                                "(SELECT m.Id as Id, Name, ChineseName, ParentId, Sequence, mmmo.MainOptr_Id FROM MainModule AS m INNER JOIN MainModule_MainOptr AS mmmo ON m.Id=mmmo.MainModule_Id) mm " +
                                "inner JOIN MainOptr mo ON mm.MainOptr_Id = mo.Id WHERE (mo.Id = @Id) Order By mm.ParentId,mm.Sequence",
            new DataParameter("@id", id));
            dt = DbEntry.Context.ExecuteDataset(sqlStatement).Tables[0];
            return dt;

        }

        /// <summary>
        /// 判断是否有子目录
        /// </summary>
        /// <param name="id">目录id</param>
        /// <returns>是否有子目录</returns>
        public static bool CheckIfHasChildren(int id)
        {
            int result = MainModule.Find(CK.K["ParentId"] == id).Count;
            if (result != 0)
                return true;
            return false;
        }
    }
}
