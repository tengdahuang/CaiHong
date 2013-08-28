using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lephone.Data;
using ChildCafe.Dal;
using Lephone.Data.SqlEntry;

namespace ChildCafe.Bll
{
    public class BllBaseInfoMember
    {
        public static DataTable GetTable(string optrType)
        {
            SqlStatement ss = new SqlStatement("Select * from v_BaseInfoMember where 用户类型 = @optrType", new DataParameter("@optrType", optrType));
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        }

        public static DataTable GetRemain(string optrType,int idays)
        {
            SqlStatement ss = new SqlStatement("Select * from v_BaseInfoMember_BirthRemind where 天数>= 0 and 天数 <= @idays and 用户类型 = @optrType", new DataParameter("@idays", idays), new DataParameter("@optrType",optrType));
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];

        }

        internal static void DelCell(long id)
        {
            BaseInfoMember.DeleteAll(CK.K["Id"] == id);
        }
    }
}
