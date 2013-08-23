using System;
using System.Collections.Generic;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllEquipmentNotice
    {


        public static List<EquipmentInformation> GetEquipmentType(string optrType, string equipmentType)
        {
            EquipmentInformation md = EquipmentInformation.New;
            md.Id = 0;
            md.EquipmentNo = "";

            List<EquipmentInformation> equipmentInformations = EquipmentInformation.Find(CK.K["OptrType"] == optrType && CK.K["EquipmentType"] == equipmentType && CK.K["Condition"] == "生产");
            equipmentInformations.Insert(0, md);
            return equipmentInformations;

        }

        public static List<string> GetEquipmentTypeString(string optrType, string equipmentType)
        {
            EquipmentInformation md = EquipmentInformation.New;
            md.Id = 0;
            md.EquipmentNo = "";

            List<EquipmentInformation> equipmentInformations = EquipmentInformation.Find(CK.K["OptrType"] == optrType && CK.K["EquipmentType"] == equipmentType && CK.K["Condition"] == "生产");
            equipmentInformations.Insert(0, md);

            List<string> s = null;
            foreach (var equipmentInformation in equipmentInformations)
            {
                s.Add(equipmentInformation.EquipmentNo);
            }
            return s;

        }

        public static List<EquipmentInformation> GetEquipmentNoByProcess(string optrType,string process)
        {
            EquipmentInformation md = EquipmentInformation.New;
            md.Id = 0;
            md.EquipmentNo = "";

            List<EquipmentInformation> equipmentInformations = EquipmentInformation.Find(CK.K["OptrType"] == optrType && CK.K["Condition"] == "生产" && CK.K["Process"] == process && CK.K["EquipmentType"] != "测试仪" && CK.K["EquipmentType"] != "测试系统" );
            equipmentInformations.Insert(0, md);
            return equipmentInformations;

        }

        /// <summary>
        /// 按Optrtype和WorkShop获得报修人
        /// </summary>
        /// <param name="optrType">用户类型</param>
        /// <param name="workshop">工作区</param>
        /// <returns></returns>
        public static List<HrPersonnelFile> GetWhoNoticeByProcess(string optrType,string workshop)
        {
            HrPersonnelFile md = HrPersonnelFile.New;
            md.Id = 0;
            md.Name = "";

            List<HrPersonnelFile> hrPersonnelFiles = HrPersonnelFile.Find(
                CK.K["OptrType"] == optrType &&
                (CK.K["WorkShop"] == workshop || CK.K["WorkShop"] == "部门") && 
                CK.K["Status"] == "在职" &&
                (CK.K["Position"] == "主管工程师" ||
                CK.K["Position"] == "维修班长" ||
                CK.K["Position"] == "操作工" ||
                CK.K["Position"] == "组长" ||
                CK.K["Position"] == "技术员" ||
                CK.K["Position"] == "工程师"), "Position");
            hrPersonnelFiles.Insert(0, md);
            return hrPersonnelFiles;

        }



    }
}
