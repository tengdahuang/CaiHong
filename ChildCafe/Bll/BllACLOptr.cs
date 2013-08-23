using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;
using XSolo.Common;

namespace ChildCafe.Bll
{
    public class BllACLOptr
    {
        public static DataTable GetMainOptrDataTable(string type)
        {
            if (type != "All")
            {
                var dt = MainOptr.Find(CK.K["IsDeleted"] == 0 && CK.K["MainOptrType"] == type).ToDataTable();
                dt.Columns.Remove("Password");
                dt.Columns[1].ColumnName = "用户名";
                dt.Columns[2].ColumnName = "中文名";
                dt.Columns[3].ColumnName = "类型";
                dt.Columns[4].ColumnName = "备注";
                dt.Columns[5].ColumnName = "保存时间";
                return dt;
            }
            else
            {
                var dt = MainOptr.Find(CK.K["IsDeleted"] == 0).ToDataTable();
                dt.Columns.Remove("Password");
                dt.Columns[1].ColumnName = "用户名";
                dt.Columns[2].ColumnName = "中文名";
                dt.Columns[3].ColumnName = "类型";
                dt.Columns[4].ColumnName = "备注";
                dt.Columns[5].ColumnName = "保存时间";
                return dt;
            }

        }

        public static void DelCell(long id)
        {
            MainOptr.DeleteAll(CK.K["Id"] == id);
        }

        //public static DataTable GetUserActions(long optrId, long moduleId)
        //{
        //    //找出该用户再这个模块的操作权限，但不包含"查看"
        //    SqlStatement ss = new SqlStatement("select * from MainAction where Id in (select [MainAction_Id] from [MainOptrAction] where [MainOptr_Id] = @OptrId and [MainModule_Id] = @ModuleId ) and Status = 0", new DataParameter("@OptrId", optrId), new DataParameter("@ModuleId", moduleId));
        //    return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        //    //long 

        //    //DataTable dtAction = new DataTable();


        //    //foreach (DataRow dtRows in dtAction.Rows)
        //    //{
        //    //    SqlStatement ss2 = new SqlStatement("select * from MainAction where Id = @ActionId", new DataParameter("@ActionId", dtRows["MainAction_Id"].ToString()));
        //    //    dtAction.Rows.Add(DbEntry.Context.ExecuteDataset(ss2).Tables[0].Rows[0]);
        //    //}

        //    //return dtAction;
        //}



        public static MainOptrType GetMainOptrTypeById(long id)
        {
            return MainOptrType.FindById(id);
        }

    }
}
