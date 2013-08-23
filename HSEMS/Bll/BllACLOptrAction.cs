using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace HSEMS.Bll
{
    public class BllACLOptrAction
    {
        public static IList<MainAction> GetAllActions(long Id)
        {
            MainModule mainModule = MainModule.FindById(Id);
            
            return mainModule.Actions;
        }

        public static IList<MainAction> GetOptrActions(long optrId, long moduleId)
        {
            SqlStatement ss = new SqlStatement("select [MainAction_Id] from [MainOptrAction] where [MainOptr_Id] = @OptrId and [MainModule_Id] = @ModuleId ", new DataParameter("@OptrId",optrId), new DataParameter("@ModuleId",moduleId));
            DataTable dt = DbEntry.Context.ExecuteDataset(ss).Tables[0];
            IList<MainAction> ma = new List<MainAction>();
            foreach (DataRow dtRows in dt.Rows)
            {
                ma.Add(MainAction.FindById(long.Parse(dtRows["MainAction_Id"].ToString())));
            }

            return ma;
            //return MainOptr.FindById(id).Modules;
        }

        public static void DeleteOptrAction(long optrId,long moduleId, long actionId)
        {
            SqlStatement ss = new SqlStatement("Delete from [MainOptrAction] where [MainOptr_Id] = @OptrId and [MainModule_Id] = @ModuleId and [MainAction_Id] = @ActionId", new DataParameter("@OptrId", optrId), new DataParameter("@ModuleId", moduleId), new DataParameter("@ActionId", actionId));
            DbEntry.Context.ExecuteNonQuery(ss);
        }

        public static void InsertOptrAction(long optrId, long moduleId, long actionId)
        {
            DeleteOptrAction(optrId,moduleId,actionId);
            SqlStatement ss = new SqlStatement("Insert into [MainOptrAction] ([MainOptr_Id], [MainModule_Id], [MainAction_Id]) Values (@OptrId, @ModuleId, @ActionId)", new DataParameter("@OptrId", optrId), new DataParameter("@ModuleId", moduleId), new DataParameter("@ActionId", actionId));
            DbEntry.Context.ExecuteNonQuery(ss);
        }
    }
}
