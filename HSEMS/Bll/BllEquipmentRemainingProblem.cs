using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HSEMS.Common;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllEquipmentRemainingProblem
    {
        public static DataTable GetTable(string optrType)
        {

            var dt = EquipmentMaintenance.Find(CK.K["OptrType"] == optrType && CK.K["Status"] == EquipmentResult.遗留问题.ToString()).ToDataTable();
            dt.Columns[1].ColumnName = "机台号";
            dt.Columns[2].ColumnName = "工序";
            dt.Columns[3].ColumnName = "测试系统";
            dt.Columns[4].ColumnName = "模具号";
            dt.Columns[5].ColumnName = "测试仪";
            dt.Columns[6].ColumnName = "品种";
            dt.Columns[7].ColumnName = "批号";
            dt.Columns[8].ColumnName = "报修人";
            dt.Columns[9].ColumnName = "报修日期";
            dt.Columns[10].ColumnName = "管理分类";
            dt.Columns[11].ColumnName = "故障现象";
            dt.Columns[12].ColumnName = "接单日期";
            dt.Columns[13].ColumnName = "接单人";
            dt.Columns[14].ColumnName = "故障确认";
            dt.Columns[15].ColumnName = "原因分析";
            dt.Columns[16].ColumnName = "维修内容";
            dt.Columns[17].ColumnName = "效果确认";
            dt.Columns[18].ColumnName = "故障分类";
            dt.Columns[19].ColumnName = "产品处理";
            dt.Columns[20].ColumnName = "修复日期1";
            dt.Columns[21].ColumnName = "协助人员1";
            dt.Columns[22].ColumnName = "当班班长1";
            dt.Columns[23].ColumnName = "更换备件1";
            dt.Columns[24].ColumnName = "遗留问题";
            dt.Columns[25].ColumnName = "备注";
            dt.Columns[26].ColumnName = "修复者2";
            dt.Columns[27].ColumnName = "协助人员2";
            dt.Columns[28].ColumnName = "当班班长2";
            dt.Columns[29].ColumnName = "更换备件2";
            dt.Columns[30].ColumnName = "修复日期2";
            dt.Columns[31].ColumnName = "处理确认";
            dt.Columns[32].ColumnName = "复测机台";
            dt.Columns[33].ColumnName = "处理者";
            dt.Columns[34].ColumnName = "处理日期1";
            dt.Columns[35].ColumnName = "已隔离";
            dt.Columns[36].ColumnName = "问题处理";
            dt.Columns[37].ColumnName = "处理日期2";
            dt.Columns[39].ColumnName = "流程状态";

            return dt;

        }

    }
}
