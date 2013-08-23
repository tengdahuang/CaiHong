using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lephone.Data;
using TDAccessControl.DataAccess;
using XSolo.Common;

namespace TDAccessControl.BLL
{
    public class BllACLUser
    {
        public static DataTable GetMainOptrDataTable()
        {
            var dt = MainOptr.Find(CK.K["IsDeleted"] == 0).ToDataTable();
            dt.Columns[1].ColumnName = "名称";
            dt.Columns[2].ColumnName = "密码";
            dt.Columns[3].ColumnName = "备注";
            dt.Columns[4].ColumnName = "更新日期";
            return dt;

        }
        
        public static void DelCell(long id)
        {
            MainOptr.DeleteAll(CK.K["Id"] == id);
        }



    }
}
