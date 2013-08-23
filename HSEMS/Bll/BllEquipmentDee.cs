using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Common;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllEquipmentDee
    {
        /// <summary>
        /// 取出所有DEE数据
        /// </summary>
        /// <param name="optrType">操作类型</param>
        /// <returns>所有DEE的DataTable</returns>
        public static DataTable GetTableByTimeSpan(string beginDate, string endDate, string optrType)
        {
            var dt = EquipmentDee.Find(CK.K["OptrType"] == optrType && CK.K["DeeDate"] >= beginDate && CK.K["DeeDate"] <= endDate).ToDataTable();
            dt.Columns[1].ColumnName = "机台号";
            dt.Columns[2].ColumnName = "模具号";
            dt.Columns[3].ColumnName = "日期";
            dt.Columns[4].ColumnName = "班组";
            dt.Columns[5].ColumnName = "组长";
            dt.Columns[6].ColumnName = "维修班长";
            dt.Columns[7].ColumnName = "操作工";
            dt.Columns[8].ColumnName = "工序";
            dt.Columns[9].ColumnName = "当前品种";
            dt.Columns[10].ColumnName = "实际产量";
            dt.Columns[11].ColumnName = "复测产量";
            dt.Columns[12].ColumnName = "停产";
            dt.Columns[13].ColumnName = "故障次数";
            dt.Columns[14].ColumnName = "故障耗时";
            dt.Columns[15].ColumnName = "待料";
            dt.Columns[16].ColumnName = "试验";
            dt.Columns[17].ColumnName = "QA";
            dt.Columns[18].ColumnName = "更换次数";
            dt.Columns[19].ColumnName = "更换耗时";
            dt.Columns[20].ColumnName = "清模";
            dt.Columns[21].ColumnName = "PM";
            dt.Columns[22].ColumnName = "减产原因";
            dt.Columns[23].ColumnName = "适应产品";
            dt.Columns[24].ColumnName = "统计分类";
            dt.Columns[25].ColumnName = "UPH";
            dt.Columns[26].ColumnName = "定额";
            dt.Columns[27].ColumnName = "管理分组";
            dt.Columns[28].ColumnName = "用户类型";

            return dt;

        }

        public static DataTable GetOneWeek(string optrType)
        {
            DateTime now = DateTime.Now;
            DateTime d1 = now.AddDays(-8);
            var dt = EquipmentDee.Find(CK.K["OptrType"] == optrType && CK.K["DeeDate"] > d1, "DeeDate desc" ).ToDataTable();
            dt.Columns[1].ColumnName = "机台号";
            dt.Columns[2].ColumnName = "模具号";
            dt.Columns[3].ColumnName = "日期";
            dt.Columns[4].ColumnName = "班组";
            dt.Columns[5].ColumnName = "组长";
            dt.Columns[6].ColumnName = "维修班长";
            dt.Columns[7].ColumnName = "操作工";
            dt.Columns[8].ColumnName = "工序";
            dt.Columns[9].ColumnName = "当前品种";
            dt.Columns[10].ColumnName = "实际产量";
            dt.Columns[11].ColumnName = "复测产量";
            dt.Columns[12].ColumnName = "停产";
            dt.Columns[13].ColumnName = "故障次数";
            dt.Columns[14].ColumnName = "故障耗时";
            dt.Columns[15].ColumnName = "待料";
            dt.Columns[16].ColumnName = "试验";
            dt.Columns[17].ColumnName = "QA";
            dt.Columns[18].ColumnName = "更换次数";
            dt.Columns[19].ColumnName = "更换耗时";
            dt.Columns[20].ColumnName = "清模";
            dt.Columns[21].ColumnName = "PM";
            dt.Columns[22].ColumnName = "减产原因";
            dt.Columns[23].ColumnName = "适应产品";
            dt.Columns[24].ColumnName = "统计分类";
            dt.Columns[25].ColumnName = "UPH";
            dt.Columns[26].ColumnName = "定额";
            dt.Columns[27].ColumnName = "管理分组";
            dt.Columns[28].ColumnName = "用户类型";

            return dt;

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

        public static List<HrPersonnelFile> GetRepairMonitorByWorkShop(string optrType, string workShop)
        {
                HrPersonnelFile md = HrPersonnelFile.New;
                md.Id = 0;
                md.Name = "";

                List<HrPersonnelFile> hrPersonnelFiles =
                    HrPersonnelFile.Find(CK.K["OptrType"] == optrType && (CK.K["WorkShop"] == workShop || CK.K["WorkShop"] == "部门") &&
                                         CK.K["Status"] == "在职" &&
                                         CK.K["Position"] == "维修班长");
                hrPersonnelFiles.Insert(0, md);
                return hrPersonnelFiles;

        }

        public static List<HrPersonnelFile> GetOperatorByWorkShop(string optrType, string workShop)
        {
            HrPersonnelFile md = HrPersonnelFile.New;
            md.Id = 0;
            md.Name = "";

            List<HrPersonnelFile> hrPersonnelFiles = HrPersonnelFile.Find(CK.K["OptrType"] == optrType && CK.K["WorkShop"] == workShop && CK.K["Status"] == "在职" && (CK.K["Position"] == "操作工" || CK.K["Position"] == "组长"));
            hrPersonnelFiles.Insert(0, md);
            return hrPersonnelFiles;

        }

        public static void DelCell(long id)
        {
            EquipmentDee.DeleteAll(CK.K["Id"] == id);
        }

    }
}
