using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;


namespace HSEMS.Bll
{
    public class BllACLOptrModule
    {
        //public static DataTable GetMainModuleDataTable()
        //{
        //    var dt = DbEntry.Context.ExecuteDataset("Select * from MainModule").Tables[0];
        //    dt.Columns[0].ColumnName = "Id";
        //    dt.Columns[1].ColumnName = "名称";
        //    dt.Columns[2].ColumnName = "中文名";
        //    dt.Columns[3].ColumnName = "父窗体";
        //    dt.Columns[4].ColumnName = "更新时间";
        //    dt.Columns[5].ColumnName = "状态";
        //    dt.Columns[6].ColumnName = "是否删除";
        //    return dt;

        //}

        public static IList<MainModule> GetAllModules(string name)
        {
            if (name == "root")
            {
                return MainModule.FindAll("ParentId,Sequence");
            }
            return MainModule.Find(CK.K["Status"] != 9, "ParentId,Sequence");
        }

        public static IList<MainModule> GetOptrModules( long id )
        {
            return MainOptr.FindById(id).Modules;
        }

        public static void DeleteUserModule(long id, long mmId)
        {
            DbEntry.UsingTransaction(delegate
            {
                MainOptr mo = MainOptr.FindById(id);
                MainModule ma = MainModule.FindById(mmId);
                mo.Modules.Remove(ma);
                mo.Save();
            });


        }

        public static void InsertUserModule(long id, long mmId)
        {
            DbEntry.UsingTransaction(delegate
            {
                DeleteUserModule(id, mmId);
                MainOptr mm = MainOptr.FindById(id);
                MainModule ma = MainModule.FindById(mmId);
                mm.Modules.Add(ma);
                mm.Save();
            });

        }
    }
}
