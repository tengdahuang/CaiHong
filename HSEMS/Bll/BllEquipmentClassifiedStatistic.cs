using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace HSEMS.Bll
{
    public class BllEquipmentClassifiedStatistic
    {

        public static DataTable GetTable(string optrType)
        {
            SqlStatement ss = new SqlStatement("SELECT * FROM v_EquipmentAllQuery where 操作类型 = @optrType", new DataParameter("@optrType", optrType));
            var dt = DbEntry.Context.ExecuteDataset(ss).Tables[0];

            return dt;

        }
    }
}
