using Lephone.Data;
using Lephone.Data.SqlEntry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChildCafe.Bll
{
    public class BllBaseInfoCard
    {
        public static DataTable GetTable(string optrType)
        {
            SqlStatement ss = new SqlStatement("Select * from v_BaseInfoCard where 用户类型 = @optrType", new DataParameter("@optrType", optrType));
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        }

    }
}
