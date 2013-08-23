using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace ChildCafe.Bll
{
    public class BllMainDict
    {
        //public static DataTable GetUserActions(long optrId, long moduleId)
        //{
        //    //找出该用户在这个模块的操作权限，但不包含"查看"
        //    SqlStatement ss = new SqlStatement("select * from MainAction where Id in (select [MainAction_Id] from [MainOptrAction] where [MainOptr_Id] = @OptrId and [MainModule_Id] = @ModuleId ) and Status = 0", new DataParameter("@OptrId", optrId), new DataParameter("@ModuleId", moduleId));
        //    return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        //}

        public static DataTable GetTable(string optr, string optrType, string dictType)
        {
            DataTable dt;
            if (optr == "root")
            {
                if (dictType != "请选择")
                {
                    dt = MainDict.Find(CK.K["DictType"] == dictType).ToDataTable();

                }
                else
                {
                    dt = MainDict.FindAll().ToDataTable();

                }

            }
            else
            {
                if (dictType != "请选择")
                {
                    dt = MainDict.Find(CK.K["OptrType"] == optrType && CK.K["DictType"] == dictType).ToDataTable();

                }
                else
                {
                    dt = MainDict.Find(CK.K["OptrType"] == optrType).ToDataTable();

                }
            }
            
            //dt.Columns.Remove("OptrType");
            dt.Columns.Remove("PreName");
            dt.Columns[1].ColumnName = "名称";
            dt.Columns[2].ColumnName = "类型";
            dt.Columns[3].ColumnName = "操作类型";
            dt.Columns[4].ColumnName = "备注";
            dt.Columns[5].ColumnName = "修改时间";
            return dt;
        }

        //public static DataTable GetAllMainDictTable(string optrType)
        //{
        //        var dt = MainDict.Find(CK.K["OptrType"] == optrType).ToDataTable();
        //        dt.Columns.Remove("OptrType");
        //        dt.Columns.Remove("PreName");
        //        dt.Columns[1].ColumnName = "名称";
        //        dt.Columns[2].ColumnName = "类型";
        //        dt.Columns[3].ColumnName = "备注";
        //        return dt;
        //}

        public static void DelCell(long id)
        {
            //保留删除之前的名称然后才删除
            var mainDict = MainDict.FindById(id);
            mainDict.PreName = mainDict.Name;
            mainDict.Save();
            MainDict.DeleteAll(CK.K["Id"] == id);
        }

        public static List<MainDictType> GetDictType(string optrType)
        {
            MainDictType md = MainDictType.New;
            md.Id = 0;
            md.Name = "请选择";
            if(optrType == "All")
            {
                List<MainDictType> mainDictTypes = MainDictType.FindAll();
                mainDictTypes.Insert(0, md);

                return mainDictTypes;
            }
            else
            {
                List<MainDictType> mainDictTypes = MainDictType.Find(CK.K["OptrType"] == optrType);
                mainDictTypes.Insert(0, md);

                return mainDictTypes;
            }
                

        }
    }
}
