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
            //SqlStatement ss = new SqlStatement("Select * from v_BaseInfoMember");
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];
            //var dt = BaseInfoMember.Find(CK.K["OptrType"] == optrType).ToDataTable();
            //dt.Columns[1].ColumnName = "开卡日期";
            //dt.Columns[2].ColumnName = "卡号";
            //dt.Columns[3].ColumnName = "姓名";
            //dt.Columns[4].ColumnName = "简拼";
            //dt.Columns[5].ColumnName = "密码";
            //dt.Columns[6].ColumnName = "生日";
            //dt.Columns[7].ColumnName = "手机";
            //dt.Columns[8].ColumnName = "电话";
            //dt.Columns[9].ColumnName = "折扣率";
            //dt.Columns[10].ColumnName = "会员余额";
            //dt.Columns[11].ColumnName = "会员积分";
            //dt.Columns[12].ColumnName = "消费次数";
            //dt.Columns[13].ColumnName = "消费总额";
            //dt.Columns[14].ColumnName = "备注";
            //dt.Columns[15].ColumnName = "修改日期";
            //dt.Columns[16].ColumnName = "用户类型";
            //return dt;

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
