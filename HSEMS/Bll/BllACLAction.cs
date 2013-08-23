using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;
using XSolo.Common;

namespace HSEMS.Bll
{
    public class BllACLAction
    {
        public static DataTable GetTable()
        {
            var dt = MainAction.Find(CK.K["IsDeleted"] == 0).ToDataTable();
            dt.Columns[1].ColumnName = "名称";
            dt.Columns[2].ColumnName = "中文名";
            dt.Columns[3].ColumnName = "图片顺序";
            dt.Columns[4].ColumnName = "快捷方式";
            dt.Columns[5].ColumnName = "状态";
            dt.Columns[6].ColumnName = "排列顺序";
            return dt;
        }

        public static void DelCell(long id)
        {
            MainAction.DeleteAll(CK.K["Id"] == id);
        }

        //public static DataTable GetActions(long id)
        //{
        //    //找出当前module下的action
        //    MainModule mainModule = MainModule.FindById(id);
        //    IList<MainAction> mainActions = mainModule.Actions;
        //    DataTable dt = IList2DataSet.ConvertToDataSet(mainActions).Tables[0];
        //    return dt;
        //}

        //public static DataTable GetActions(long id)
        //{
        //    SqlStatement sqlStatement =
        //        new SqlStatement("SELECT MainAction.Id as Id, MainAction.Name AS Name, " +
        //                         "MainAction.ChineseName AS ChineseName, " +
        //                         "MainAction.ImageOrder AS ImageOrder, " +
        //                         "MainAction.ShortCut AS ShortCut, " +
        //                         "MainAction.IsDeleted AS IsDeleted " +
        //                         "FROM MainAction " +
        //                         "INNER JOIN MainAction_MainModule " +
        //                         "ON MainAction.Id = MainAction_MainModule.MainAction_Id " +
        //                         "INNER JOIN MainModule " +
        //                         "ON MainAction_MainModule.MainModule_Id = MainModule.Id " +
        //                         "WHERE (MainModule.Id = @id)",
        //                         new DataParameter("@id", id));
        //    return DbEntry.Context.ExecuteDataset(sqlStatement).Tables[0];
        //}
    }
}
