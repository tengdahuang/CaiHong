using System;
using System.Collections.Generic;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllEquipmentVariation
    {


        public static List<EquipmentInformation> GetEquipmentNoByProcess(string optrType, string process)
        {
            EquipmentInformation md = EquipmentInformation.New;
            md.Id = 0;
            md.EquipmentNo = "";

            List<EquipmentInformation> equipmentInformations = EquipmentInformation.Find(CK.K["OptrType"] == optrType && CK.K["Process"] == process && CK.K["Condition"] == "生产" && CK.K["EquipmentType"] != "测试仪" && CK.K["EquipmentType"] != "测试系统");
            equipmentInformations.Insert(0, md);
            return equipmentInformations;

        }

        public static List<HrPersonnelFile> GetDistributor(string optrType)
        {
            HrPersonnelFile md = HrPersonnelFile.New;
            md.Id = 0;
            md.Name = "";

            List<HrPersonnelFile> hrPersonnelFiles = HrPersonnelFile.Find(CK.K["OptrType"] == optrType && (CK.K["WorkShop"] == "测试区" || CK.K["WorkShop"] == "部门") && CK.K["Status"] == "在职" && (CK.K["Position"] == "主管工程师" || CK.K["Position"] == "操作工" || CK.K["Position"] == "组长" || CK.K["Position"] == "技术员" || CK.K["Position"] == "工程师"), "Position");
            hrPersonnelFiles.Insert(0, md);
            return hrPersonnelFiles;

        }
    }
}
