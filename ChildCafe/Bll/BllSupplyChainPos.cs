using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace ChildCafe.Bll
{
    public class BllSupplyChainPos
    {
        public static string GetPosSN()
        {
            SqlStatement ss = new SqlStatement("Select * from v_SupplyChainPosGetSN");
            DataTable dt = DbEntry.Context.ExecuteDataset(ss).Tables[0];

            if (dt.Rows.Count != 0)
            {
                string s = dt.Rows[0][0].ToString();
                //1.截取前8位字符，判断日期是否是当天，如果不是，则以当天+001生成新流水号，如果是则流水号+1
                StringBuilder d = new StringBuilder(DateTime.Now.Date.ToString("yyyyMMdd"));
                if (d.ToString() == s.Substring(0, 8))
                {
                    return (long.Parse(s) + 1).ToString();
                }
                else
                {
                    d.Append("001");
                    return d.ToString();
                }
            }
            else
            {
                StringBuilder d = new StringBuilder(DateTime.Now.Date.ToString("yyyyMMdd"));
                d.Append("001");
                return d.ToString();
            }

        }

        public static DataTable GetPosDetail(long PosId)
        {
            SqlStatement ss = new SqlStatement("Select * from v_SupplyChainPosDetail where SupplyChainPosId = @SupplyChainPosId", new DataParameter("@SupplyChainPosId", PosId));
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        }

    }
}
