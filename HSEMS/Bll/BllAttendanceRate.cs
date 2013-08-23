using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Common;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllAttendanceRate
    {
        public static DataTable GetOneWeek(string optrType)
        {
            DateTime now = DateTime.Now;
            DateTime d1 = now.AddDays(-8);
            var dt = AttendanceRate.Find(CK.K["OptrType"] == optrType && CK.K["InputDate"] > d1, "InputDate desc").ToDataTable();
            dt.Columns[1].ColumnName = "日期";
            dt.Columns[2].ColumnName = "区域";
            dt.Columns[3].ColumnName = "组长";
            dt.Columns[4].ColumnName = "管理人员";
            dt.Columns[5].ColumnName = "技术人员";
            dt.Columns[6].ColumnName = "辅助人员";
            dt.Columns[7].ColumnName = "大功率操作工";
            dt.Columns[8].ColumnName = "小功率操作工";
            dt.Columns[9].ColumnName = "新工";
            dt.Columns[10].ColumnName = "缺勤";
            dt.Columns[11].ColumnName = "大功率测试产量";
            dt.Columns[12].ColumnName = "小功率测试产量";
            dt.Columns[13].ColumnName = "小功率打印产量";
            dt.Columns[14].ColumnName = "编带产量";
            dt.Columns[15].ColumnName = "包装全检产量";
            dt.Columns[16].ColumnName = "包装合批产量";
            dt.Columns[17].ColumnName = "大功率交库";
            dt.Columns[18].ColumnName = "大功率委托";
            dt.Columns[19].ColumnName = "中功率交库";
            dt.Columns[20].ColumnName = "中功率委托";
            dt.Columns[21].ColumnName = "小功率交库";
            dt.Columns[22].ColumnName = "小功率委托";
            dt.Columns[23].ColumnName = "异常用人";
            dt.Columns[24].ColumnName = "异常原因";
            dt.Columns[25].ColumnName = "备注";
            dt.Columns[26].ColumnName = "用户类型";

            return dt;

        }

        public static void DelCell(long id)
        {
            AttendanceRate.DeleteAll(CK.K["Id"] == id);
        }

        public static List<HrPersonnelFile> GetGroupMonitorByWorkShop(string optrType,string workShop)
        {
                HrPersonnelFile md = HrPersonnelFile.New;
                md.Id = 0;
                md.Name = "";

                List<HrPersonnelFile> hrPersonnelFiles =
                    HrPersonnelFile.Find(CK.K["OptrType"] == optrType && CK.K["WorkShop"] == workShop &&
                                         CK.K["Status"] == "在职" &&
                                         CK.K["Position"] == "组长");
                hrPersonnelFiles.Insert(0, md);
                return hrPersonnelFiles;

        }
    }
}
