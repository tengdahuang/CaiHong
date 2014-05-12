using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChildCafe.Common;

namespace ChildCafe.Bll
{
    public class BllBaseInfoCard
    {
        public static DataTable GetTable(string optrType)
        {
            SqlStatement ss = new SqlStatement("Select * from BaseInfoCard where OptrType = @optrType", new DataParameter("@optrType", optrType));
            //return DbEntry.Context.ExecuteDataset(ss).Tables[0];
            return ChineseColumnName<BaseInfoCard>.SetColumn(DbEntry.Context.ExecuteDataset(ss).Tables[0]);
        }

        //public static string GetBaseInfoCardMessage()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    List<string> message = ChineseColumnName<BaseInfoCard>.GetListColumnNames<BaseInfoCard>();
        //    foreach(string s in message)
        //    {
        //        sb.AppendLine(s);
        //    }
        //    return sb.ToString();
        //}

    }
}
