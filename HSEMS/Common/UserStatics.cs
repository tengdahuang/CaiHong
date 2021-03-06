﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace HSEMS.Common
{
    class UserStatics
    {
        public static string OptrName = "";
        public static long OptrId;
        public static string OptrType = "";
        public static string WorkShop = "";

        public static DataTable GetUserActions(long moduleId)
        {
            //找出该用户在这个模块的操作权限，但不包含状态为非0的
            SqlStatement ss = new SqlStatement("select * from MainAction where Id in (select [MainAction_Id] from [MainOptrAction] where [MainOptr_Id] = @OptrId and [MainModule_Id] = @ModuleId ) and Status = 0", new DataParameter("@OptrId", OptrId), new DataParameter("@ModuleId", moduleId));
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];

        }

        public static List<MainOptrType> GetUserTypes(long id)
        {
            if (id == 1)
                return MainOptrType.FindAll();
            return MainOptrType.Find(CK.K["Status"] == 1);

        }

        public static DateTime GetSqlServerDateTime()
        {
            SqlStatement ss = new SqlStatement("select CONVERT(varchar(100),getDate(),120)");
            return Convert.ToDateTime(DbEntry.Context.ExecuteDataset(ss).Tables[0].Rows[0][0]);
        }


    }
}
