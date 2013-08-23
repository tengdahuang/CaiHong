using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace HSEMS.Bll
{
    public class BllEquipmentVariationQuery
    {
        public static DataTable GetAllTable(string optrType)

        {
            SqlStatement ss = new SqlStatement("SELECT * FROM v_EquipmentVariationQuery where 操作类型 = @optrType", new DataParameter("@optrType", optrType));
            var dt = DbEntry.Context.ExecuteDataset(ss).Tables[0];

            return dt;

        }

        
    }
}
