using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace ChildCafe.Bll
{
    public class BllBaseInfoMaterialIngredients
    {

        public static DataTable GetSrcTable(string optrType)
        {
            SqlStatement ss = new SqlStatement("Select * from v_BaseInfoMaterialSrc where 分类='半成品-小吃' or 分类 = '半成品-茶' or 分类 = '其他'");
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        }

        public static DataTable GetDestTable(string optrType,string sId)
        {
            SqlStatement ss = new SqlStatement("Select * from v_BaseInfoMaterialIngredient where Pid = @Id", new DataParameter("@Id", sId));
            return DbEntry.Context.ExecuteDataset(ss).Tables[0];
        }

        internal static void DelCell(long id)
        {
            BaseInfoMaterial.DeleteAll(CK.K["Id"] == id);
        }

    }
}
