using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllEquipmentInformation
    {
        public static DataTable GetTable(string optrType)
        {
            var dt = EquipmentInformation.Find(CK.K["OptrType"] == optrType).ToDataTable();
            dt.Columns[1].ColumnName = "设备分类";
            dt.Columns[2].ColumnName = "机台号";
            dt.Columns[3].ColumnName = "设备型号";
            dt.Columns[4].ColumnName = "适应产品";
            dt.Columns[5].ColumnName = "单位产量";
            dt.Columns[6].ColumnName = "班产定额";
            dt.Columns[7].ColumnName = "使用状态";
            dt.Columns[8].ColumnName = "管理分组";
            dt.Columns[9].ColumnName = "设备分级";
            dt.Columns[10].ColumnName = "测试站";
            dt.Columns[11].ColumnName = "通道数";
            dt.Columns[12].ColumnName = "制造厂家";
            dt.Columns[13].ColumnName = "制造时间";
            dt.Columns[14].ColumnName = "进厂时间";
            dt.Columns[15].ColumnName = "生产适应性";
            dt.Columns[16].ColumnName = "统计分类";
            dt.Columns[17].ColumnName = "工序";
            dt.Columns[18].ColumnName = "模具号";
            dt.Columns[19].ColumnName = "备注";
            dt.Columns[20].ColumnName = "操作类型";
            return dt;

        }

        public static DataTable GetPartTable(string optrType)
        {
            var dt = EquipmentInformation.Find(CK.K["OptrType"] == optrType && CK.K["Condition"] == "生产").ToDataTable();
            dt.Columns[1].ColumnName = "设备分类";
            dt.Columns[2].ColumnName = "机台号";
            dt.Columns[3].ColumnName = "设备型号";
            dt.Columns[4].ColumnName = "适应产品";
            dt.Columns[5].ColumnName = "单位产量";
            dt.Columns[6].ColumnName = "班产定额";
            dt.Columns[7].ColumnName = "使用状态";
            dt.Columns[8].ColumnName = "管理分组";
            dt.Columns[9].ColumnName = "设备分级";
            dt.Columns[10].ColumnName = "测试站";
            dt.Columns[11].ColumnName = "通道数";
            dt.Columns[12].ColumnName = "制造厂家";
            dt.Columns[13].ColumnName = "制造时间";
            dt.Columns[14].ColumnName = "进厂时间";
            dt.Columns[15].ColumnName = "生产适应性";
            dt.Columns[16].ColumnName = "统计分类";
            dt.Columns[17].ColumnName = "工序";
            dt.Columns[18].ColumnName = "模具号";
            dt.Columns[19].ColumnName = "备注";
            dt.Columns[20].ColumnName = "操作类型";
            return dt;

        }

        public static void DelCell(long id)
        {
            EquipmentInformation.DeleteAll(CK.K["Id"] == id);
        }


    }
}
