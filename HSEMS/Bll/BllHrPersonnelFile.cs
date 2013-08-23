using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllHrPersonnelFile
    {
        public static DataTable GetTable(string optrType)
        {
            var dt = HrPersonnelFile.Find(CK.K["Status"] == "在职" && CK.K["OptrType"] == optrType).ToDataTable();
            dt.Columns[1].ColumnName = "卡号";
            dt.Columns[2].ColumnName = "姓名";
            dt.Columns[3].ColumnName = "性别";
            dt.Columns[4].ColumnName = "婚姻状况";
            dt.Columns[5].ColumnName = "生日";
            dt.Columns[6].ColumnName = "籍贯";
            dt.Columns[7].ColumnName = "身份证";
            dt.Columns[8].ColumnName = "入职时间";
            dt.Columns[9].ColumnName = "车间";
            dt.Columns[10].ColumnName = "工序";
            dt.Columns[11].ColumnName = "职务";
            dt.Columns[12].ColumnName = "职称";
            dt.Columns[13].ColumnName = "工资级别";
            dt.Columns[14].ColumnName = "毕业学校";
            dt.Columns[15].ColumnName = "专业";
            dt.Columns[16].ColumnName = "学历";
            dt.Columns[17].ColumnName = "外语能力";
            dt.Columns[18].ColumnName = "计算机能力";
            dt.Columns[19].ColumnName = "政治面貌";
            dt.Columns[20].ColumnName = "电话";
            dt.Columns[21].ColumnName = "操作类型";
            dt.Columns[22].ColumnName = "在职状态";
            return dt;

        }

        public static void DelCell(long id)
        {
            HrPersonnelFile.DeleteAll(CK.K["Id"] == id);
        }


        //public static DataTable GetFinded(string txt)
        //{
        //    var dt = HrPersonnelFile.Find(CK.K["Name"] == txt || CK.K["CardNumber"] == txt).ToDataTable();
        //    dt.Columns[1].ColumnName = "卡号";
        //    dt.Columns[2].ColumnName = "姓名";
        //    dt.Columns[3].ColumnName = "性别";
        //    dt.Columns[4].ColumnName = "婚姻状况";
        //    dt.Columns[5].ColumnName = "生日";
        //    dt.Columns[6].ColumnName = "籍贯";
        //    dt.Columns[7].ColumnName = "身份证";
        //    dt.Columns[8].ColumnName = "入职时间";
        //    dt.Columns[9].ColumnName = "车间";
        //    dt.Columns[10].ColumnName = "工序";
        //    dt.Columns[11].ColumnName = "职务";
        //    dt.Columns[12].ColumnName = "职称";
        //    dt.Columns[13].ColumnName = "工资级别";
        //    dt.Columns[14].ColumnName = "毕业学校";
        //    dt.Columns[15].ColumnName = "专业";
        //    dt.Columns[16].ColumnName = "学历";
        //    dt.Columns[17].ColumnName = "外语能力";
        //    dt.Columns[18].ColumnName = "计算机能力";
        //    dt.Columns[19].ColumnName = "政治面貌";
        //    dt.Columns[20].ColumnName = "电话";
        //    dt.Columns[21].ColumnName = "操作类型";
        //    dt.Columns[22].ColumnName = "在职状态";
        //    return dt;
        //}

        //public static string GetAgeType(int age)
        //{
        //    if (age < 20) return "20岁以下";
        //    if (age >= 20 && age < 30) return "20-30岁";
        //    if (age >= 30 && age < 40) return "30-40岁";
        //    if (age >= 40 && age < 50) return "40-50岁";
        //    return "50岁以上";
        //}

    }
}
