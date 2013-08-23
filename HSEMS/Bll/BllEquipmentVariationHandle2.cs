using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Common;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllEquipmentVariationHandle2
    {
        public static long GetCount(string optrType)
        {
            return EquipmentVariation.GetCount(CK.K["OptrType"] == optrType && CK.K["Status"] == VariationResult.未完成.ToString());
        }

        public static DataTable GetTable(string optrType)
        {

            var dt = EquipmentVariation.Find(CK.K["OptrType"] == optrType && CK.K["Status"] == VariationResult.未完成.ToString()).ToDataTable();
            dt.Columns[1].ColumnName = "变更类别";
            dt.Columns[2].ColumnName = "变更原因";
            dt.Columns[3].ColumnName = "机台号";
            dt.Columns[4].ColumnName = "工序";
            dt.Columns[5].ColumnName = "变更前";
            dt.Columns[6].ColumnName = "变更后";
            dt.Columns[7].ColumnName = "安排人";
            dt.Columns[8].ColumnName = "安排时间";
            dt.Columns[9].ColumnName = "接单时间";
            dt.Columns[10].ColumnName = "接单维修";
            dt.Columns[11].ColumnName = "协助人员";
            dt.Columns[12].ColumnName = "搬动测试仪";
            dt.Columns[13].ColumnName = "处理内容1";
            dt.Columns[14].ColumnName = "效果确认";
            dt.Columns[15].ColumnName = "完成时间";
            dt.Columns[16].ColumnName = "更换备件";
            dt.Columns[17].ColumnName = "备注";
            dt.Columns[18].ColumnName = "最后处理";
            dt.Columns[19].ColumnName = "处理者2";
            dt.Columns[20].ColumnName = "完成日期2";
            dt.Columns[22].ColumnName = "流程状态";

            return dt;

        }

        public static List<HrPersonnelFile> GetWhoRepairByWorkShop(string optrType, string workshop)
        {
            HrPersonnelFile md = HrPersonnelFile.New;
            md.Id = 0;
            md.Name = "";

            List<HrPersonnelFile> hrPersonnelFiles =
                HrPersonnelFile.Find(CK.K["OptrType"] == optrType && (CK.K["WorkShop"] == workshop || CK.K["WorkShop"] == "部门") &&
                                     CK.K["Status"] == "在职" &&
                                     (CK.K["Position"] == "主管工程师" || CK.K["Position"] == "工程师" ||
                                      CK.K["Position"] == "维修员" || CK.K["Position"] == "技术员" || CK.K["Position"] == "维修班长"), "Position");
            hrPersonnelFiles.Insert(0, md);
            return hrPersonnelFiles;
        }

    }
}
