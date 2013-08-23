using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace HSEMS.Bll
{
    public class BllTechnologicalEquipment
    {
        public static DataTable GetTableTestOverrun()
        {
            return DbEntry.Context.ExecuteDataset("SELECT * FROM v_TechnologicalEquipment_Test_Overrun where 累计产量 > 寿命下限 and 工装类型 like '测试爪%' or (工装类型 = '成型刀' and 工装状态 = 10)").Tables[0];
        }

        public static long GetTableTestOverrunCount()
        {
            string a =
                DbEntry.Context.ExecuteDataset("SELECT count(*) FROM v_TechnologicalEquipment_Test_Overrun where 累计产量 > 寿命下限 and 工装类型 like '测试爪%' or (工装类型 = '成型刀' and 工装状态 = 10)").Tables[0].Rows[0][0].ToString();
            
            return int.Parse(a);
        }

        public static DataTable GetTableTestSharpening()
        {
            return DbEntry.Context.ExecuteDataset("SELECT * FROM v_TechnologicalEquipment_Test_Overrun where 累计产量 > 寿命下限 and 工装类型 = '成型刀' and 工装状态 < 10 ").Tables[0];

        }

        public static long GetTableTestSharpeningCount()
        {
            string a = DbEntry.Context.ExecuteDataset("SELECT count(*) FROM v_TechnologicalEquipment_Test_Overrun where 累计产量 > 寿命下限 and 工装类型 = '成型刀' and 工装状态 < 10 ").Tables[0].Rows[0][0].ToString();
            return int.Parse(a);
        }

        public static int GetUseAmount(long id)
        {
            SqlStatement sql = new SqlStatement("SELECT 累计产量 FROM v_TechnologicalEquipment_Test_Overrun where Id = @Id", new DataParameter("@Id", id));
            string a = DbEntry.Context.ExecuteDataset(sql).Tables[0].Rows[0][0].ToString();
            return int.Parse(a);
        }


        public static List<HrPersonnelFile> GetWhoRepairByWorkShop(string optrType,string workShop)
        {
                HrPersonnelFile md = HrPersonnelFile.New;
                md.Id = 0;
                md.Name = "";

                List<HrPersonnelFile> hrPersonnelFiles =
                    HrPersonnelFile.Find(CK.K["OptrType"] == optrType && (CK.K["WorkShop"] == workShop || CK.K["WorkShop"] == "部门") &&
                                         CK.K["Status"] == "在职" &&
                                         (CK.K["Position"] == "主管工程师" || CK.K["Position"] == "工程师" ||
                                          CK.K["Position"] == "维修员" || CK.K["Position"] == "技术员" || CK.K["Position"] == "维修班长"));
                hrPersonnelFiles.Insert(0, md);
                return hrPersonnelFiles;

        }

        public static DataTable GetTable(string optrType)
        {
            var dt = TechnologicalEquipment.Find(CK.K["OptrType"] == optrType, "EquipmentNo").ToDataTable();
            dt.Columns[1].ColumnName = "机台号";
            dt.Columns[2].ColumnName = "模具号";
            dt.Columns[3].ColumnName = "工装编号";
            dt.Columns[4].ColumnName = "产品类型";
            dt.Columns[5].ColumnName = "工装类型";
            dt.Columns[6].ColumnName = "工装状态";
            dt.Columns[7].ColumnName = "安装日期";
            dt.Columns[8].ColumnName = "安装者";
            dt.Columns[9].ColumnName = "原始寿命";
            dt.Columns[10].ColumnName = "寿命下限";
            dt.Columns[11].ColumnName = "寿命上限";
            dt.Columns[12].ColumnName = "拆卸日期";
            dt.Columns[13].ColumnName = "使用寿命";
            dt.Columns[14].ColumnName = "拆卸原因";
            dt.Columns[15].ColumnName = "拆卸者";
            dt.Columns[16].ColumnName = "工装处理";
            dt.Columns[17].ColumnName = "供应商";
            dt.Columns[18].ColumnName = "备注";
            dt.Columns[19].ColumnName = "用户类型";
            dt.Columns[20].ColumnName = "保存日期";
            
            return dt;

        }

        public static DataTable GetTableTestOverrunAll()
        {
            return DbEntry.Context.ExecuteDataset("SELECT * FROM v_TechnologicalEquipment_Test_Overrun").Tables[0];
        }

        public static DataTable GetNoUseTable(string optrType)
        {
            var dt = TechnologicalEquipment.Find(CK.K["OptrType"] == optrType && CK.K["TeHandle"] == "报废", "EquipmentNo").ToDataTable();
            dt.Columns[1].ColumnName = "机台号";
            dt.Columns[2].ColumnName = "模具号";
            dt.Columns[3].ColumnName = "工装编号";
            dt.Columns[4].ColumnName = "产品类型";
            dt.Columns[5].ColumnName = "工装类型";
            dt.Columns[6].ColumnName = "工装状态";
            dt.Columns[7].ColumnName = "安装日期";
            dt.Columns[8].ColumnName = "安装者";
            dt.Columns[9].ColumnName = "原始寿命";
            dt.Columns[10].ColumnName = "寿命下限";
            dt.Columns[11].ColumnName = "寿命上限";
            dt.Columns[12].ColumnName = "拆卸日期";
            dt.Columns[13].ColumnName = "使用寿命";
            dt.Columns[14].ColumnName = "拆卸原因";
            dt.Columns[15].ColumnName = "拆卸者";
            dt.Columns[16].ColumnName = "工装处理";
            dt.Columns[17].ColumnName = "供应商";
            dt.Columns[18].ColumnName = "备注";
            dt.Columns[19].ColumnName = "用户类型";
            dt.Columns[20].ColumnName = "保存日期";

            return dt;

        }

        public static void DelCell(long id)
        {
            TechnologicalEquipment.DeleteAll(CK.K["Id"] == id);
        }
    }
}
