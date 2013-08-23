using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllEquipmentOffline
    {
        public static long GetCount(string optrType)
        {
            return EquipmentOffline.GetCount(CK.K["OptrType"] == optrType && (CK.K["OfflineResultConfirm"] == "" || CK.K["OfflineResultConfirm"] == null));
        }

        public static DataTable GetTable(string optrType)
        {

            var dt = EquipmentOffline.Find(CK.K["OptrType"] == optrType && (CK.K["OfflineResultConfirm"] == "" || CK.K["OfflineResultConfirm"] == null)).ToDataTable();
            dt.Columns[1].ColumnName = "机台号";
            dt.Columns[2].ColumnName = "设备分类";
            dt.Columns[3].ColumnName = "离线原因";
            dt.Columns[4].ColumnName = "提交人";
            dt.Columns[5].ColumnName = "离线日期";
            dt.Columns[6].ColumnName = "维修记录";
            dt.Columns[7].ColumnName = "效果确认";
            dt.Columns[8].ColumnName = "修复人";
            dt.Columns[9].ColumnName = "修复日期";
            dt.Columns[10].ColumnName = "备注";
            
            return dt;

        }

        public static DataTable GetAllTable(string optrType)
        {

            var dt = EquipmentOffline.Find(CK.K["OptrType"] == optrType && CK.K["OfflineResultConfirm"] != "" && CK.K["OfflineResultConfirm"] != null).ToDataTable();
            dt.Columns[1].ColumnName = "机台号";
            dt.Columns[2].ColumnName = "设备分类";
            dt.Columns[3].ColumnName = "离线原因";
            dt.Columns[4].ColumnName = "提交人";
            dt.Columns[5].ColumnName = "离线日期";
            dt.Columns[6].ColumnName = "维修记录";
            dt.Columns[7].ColumnName = "效果确认";
            dt.Columns[8].ColumnName = "修复人";
            dt.Columns[9].ColumnName = "修复日期";
            dt.Columns[10].ColumnName = "备注";

            return dt;

        }


        public static List<EquipmentInformation> GetEquipmentNo(string optrType)
        {
            EquipmentInformation md = EquipmentInformation.New;
            md.Id = 0;
            md.EquipmentNo = "";

            List<EquipmentInformation> equipmentInformations = EquipmentInformation.Find(CK.K["OptrType"] == optrType && CK.K["Condition"] == "生产" && (CK.K["EquipmentType"] == "测试系统" || CK.K["EquipmentType"] == "测试仪" || CK.K["EquipmentType"] == "机械手" || CK.K["EquipmentType"] == "打印机" || CK.K["EquipmentType"] == "编带机" || CK.K["EquipmentType"] == "成型机" ));
            equipmentInformations.Insert(0, md);
            return equipmentInformations;

        }

        public static List<HrPersonnelFile> GetWhoNotice(string optrType)
        {
            HrPersonnelFile md = HrPersonnelFile.New;
            md.Id = 0;
            md.Name = "";

            List<HrPersonnelFile> hrPersonnelFiles = HrPersonnelFile.Find(CK.K["OptrType"] == optrType && (CK.K["WorkShop"] == "测试区" || CK.K["WorkShop"] == "部门") && CK.K["Status"] == "在职" && (CK.K["Position"] == "主管工程师" || CK.K["Position"] == "组长" || CK.K["Position"] == "技术员" || CK.K["Position"] == "工程师"), "Position");
            hrPersonnelFiles.Insert(0, md);
            return hrPersonnelFiles;

        }
    }
}
