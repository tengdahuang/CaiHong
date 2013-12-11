using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace ChildCafe.Bll
{
    public class BllBaseInfoMemberTester
    {
        public static DataTable GetTable(string optrType)
        {
            SqlStatement ss = new SqlStatement("Select * from v_BaseInfoMemberTester where 用户类型 = @optrType", new DataParameter("@optrType", optrType));
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        }

        internal static void DelCell(long id)
        {
            BaseInfoMemberTester.DeleteAll(CK.K["Id"] == id);
        }
    }
}
