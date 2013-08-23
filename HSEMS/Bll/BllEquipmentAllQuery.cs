using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Common;
using HSEMS.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace HSEMS.Bll
{
    public class BllEquipmentAllQuery
    {
        //public static DataTable GetTable(string optrType, string beginDate, string endDate, string equipmentNo, string accepter, string managementType)
        //{
        //    SqlStatement ss = new SqlStatement("SELECT * FROM v_EquipmentAllQuery where 报修日期 > ISNULL(@beginTime,2012-01-01) and 报修日期 < ISNULL(@endTime,GETDATE()) and EquipmentNo like '%@equipmentNo%' and Accepter1 like '%@accepter%' and ManagementType like '%@managementType%'",
        //        new DataParameter("@beginDate", beginDate), new DataParameter("@endDate", endDate), new DataParameter("@equipmentNo", equipmentNo), new DataParameter("@accepter", accepter), new DataParameter("@managementType", managementType));
        //    var dt = DbEntry.Context.ExecuteDataset(ss).Tables[0];

        //    return dt;

        //}


        public static DataTable GetTableByTimeSpan(string beginTime, string endTime, string optrType)
        {
            SqlStatement ss = 
                new SqlStatement("SELECT * FROM v_EquipmentAllQuery where 操作类型 = @optrType and 报修日期 between @beginTime and @endTime", 
                    new DataParameter("@optrType", optrType),
                    new DataParameter("@beginTime", beginTime),
                    new DataParameter("@endTime",endTime));
            var dt = DbEntry.Context.ExecuteDataset(ss).Tables[0];

            return dt;

        }

        public static List<HrPersonnelFile> GetWhoRepair(string optrType)
        {
            if (optrType == "Test")
            {
                HrPersonnelFile md = HrPersonnelFile.New;
                md.Id = 0;
                md.Name = "";

                List<HrPersonnelFile> hrPersonnelFiles =
                    HrPersonnelFile.Find(CK.K["OptrType"] == optrType && CK.K["WorkShop"] == "测试区" &&
                                         CK.K["Status"] == "在职" &&
                                         (CK.K["Position"] == "主管工程师" || CK.K["Position"] == "工程师" ||
                                          CK.K["Position"] == "维修员" || CK.K["Position"] == "技术员" || CK.K["Position"] == "维修班长"));
                hrPersonnelFiles.Insert(0, md);
                return hrPersonnelFiles;
            }
                return null;
        }

        public static List<HrPersonnelFile> GetGroupMonitor(string optrType)
        {
            if (optrType == "Test")
            {
                HrPersonnelFile md = HrPersonnelFile.New;
                md.Id = 0;
                md.Name = "";

                List<HrPersonnelFile> hrPersonnelFiles =
                    HrPersonnelFile.Find(CK.K["OptrType"] == optrType && CK.K["WorkShop"] == "测试区" &&
                                         CK.K["Status"] == "在职" &&
                                         CK.K["Position"] == "组长");
                hrPersonnelFiles.Insert(0, md);
                return hrPersonnelFiles;
            }
            else
            {

                return null;
            }

        }

        public static List<HrPersonnelFile> GetRepairMonitor(string optrType)
        {
            if (optrType == "Test")
            {
                HrPersonnelFile md = HrPersonnelFile.New;
                md.Id = 0;
                md.Name = "";

                List<HrPersonnelFile> hrPersonnelFiles =
                    HrPersonnelFile.Find(CK.K["OptrType"] == optrType && (CK.K["WorkShop"] == "测试区" || CK.K["WorkShop"] == "部门") &&
                                         CK.K["Status"] == "在职" &&
                                          CK.K["Position"] == "维修班长", "Position");
                hrPersonnelFiles.Insert(0, md);
                return hrPersonnelFiles;
            }
            else
            {

                return null;
            }
        }


    }
}
