using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;


namespace ChildCafe.Bll
{
    public class BllACLModuleAction
    {

        public static List<MainAction> GetActionList()
        {
            return MainAction.FindAll();

        }

        public static List<MainAction> GetModuleActions(long id)
        {
            SqlStatement sqlStatement = 
                new SqlStatement("SELECT ma.Id, ma.Name, ma.ChineseName, ma.ImageOrder, ma.ShortCut, ma.Status, ma.Sequence, ma.IsDeleted " +
                                 "FROM (SELECT *  FROM MainAction_MainModule INNER JOIN MainModule ON MainAction_MainModule.MainModule_Id = MainModule.Id) mamm INNER JOIN MainAction AS ma ON mamm.MainAction_Id = ma.Id " +
                                 " WHERE MainModule.Id = @id", new DataParameter("@id",id));
            return DbEntry.Context.ExecuteList<MainAction>(sqlStatement);

        }

        //获取该checkbox的Id
        //删除MaianMudule_MainAction
        public static void DeleteModuleAction(long id, string txt)
        {
            DbEntry.UsingTransaction(delegate
                                         {
                                             MainModule mm = MainModule.FindById(id);
                                             MainAction ma = MainAction.FindOne(CK.K["ChineseName"] == txt);
                                             mm.Actions.Remove(ma);
                                             mm.Save();
                                         });


        }

        public static void InsertModuleAction(long id, string txt)
        {
            DbEntry.UsingTransaction(delegate
            {
                DeleteModuleAction(id,txt);
                MainModule mm = MainModule.FindById(id);
                MainAction ma = MainAction.FindOne(CK.K["ChineseName"] == txt);
                mm.Actions.Add(ma);
                mm.Save();
            });

        }
    }
}
