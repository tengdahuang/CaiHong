using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;
using XSolo.Common;


namespace ChildCafe.Bll
{
    public class BllACLModule
    {
        public static DataTable GetTable()
        {
            var dt = DbEntry.Context.ExecuteDataset("Select * from MainModule order by ParentId,Sequence").Tables[0];
            dt.Columns[1].ColumnName = "名称";
            dt.Columns[2].ColumnName = "中文名";
            dt.Columns[3].ColumnName = "上一级";
            dt.Columns[4].ColumnName = "更新时间";
            dt.Columns[5].ColumnName = "状态";
            dt.Columns[6].ColumnName = "顺序";
            dt.Columns[7].ColumnName = "是否删除";
            return dt;

        }

        public static DataTable GetActions(long id)
        {
            MainModule mainModule = MainModule.FindById(id);
            IList<MainAction> mainActions = mainModule.Actions;
            DataTable dt = IList2DataSet.ConvertToDataSet(mainActions).Tables[0];
            return dt;
        }

        public static void DelCell(long id)
        {
            MainModule.DeleteAll(CK.K["Id"] == id);
        }

        public static List<MainModule> GetAllSysMenu()
        {
            MainModule mm = MainModule.New;
            mm.Id = 0;
            mm.Name = "Root";
            mm.ChineseName = "根节点";
            mm.ParentId = -1;
            List<MainModule> mainModules = MainModule.FindAll("ParentId");
            mainModules.Insert(0, mm);
            return mainModules;
        }

        public static MainModule GetMainModuleByParentID(long id)
        {
            if (id == 0)
                return MainModule.FindById(1);
            else
                return MainModule.FindById(id);
        }
    }
}
