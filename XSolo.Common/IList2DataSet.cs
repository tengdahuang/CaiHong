﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;


namespace XSolo.Common
{
    public class IList2DataSet
    {
        public static DataSet ConvertToDataSet<T>(IList<T> list)
        {
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            DataSet ds = new DataSet();
            DataTable dt = new DataTable(typeof (T).Name);
            DataColumn column;
            DataRow row;

            System.Reflection.PropertyInfo[] myPropertyInfo =
                typeof (T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            foreach (T t in list)
            {
                if (t == null)
                {
                    continue;
                }
                row = dt.NewRow();
                for (int i = 0, j = myPropertyInfo.Length; i < j; i++)
                {
                    System.Reflection.PropertyInfo pInfo = myPropertyInfo[i];
                    string name = pInfo.Name;
                    if (dt.Columns[name] == null)
                    {
                        column = new DataColumn(name, pInfo.PropertyType);
                        dt.Columns.Add(column);
                    }
                    row[name] = pInfo.GetValue(t, null);
                }
                dt.Rows.Add(row);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        public static T ConvertToEntity<T>(DataRow dr)
        {
            // 得到模型的类型
            Type type = typeof (T);
            T instance = (T) Activator.CreateInstance(type);

            PropertyInfo[] pis =
                type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty |
                                   BindingFlags.SetField);

            foreach (PropertyInfo pi in pis)
            {
                string strColumnName = pi.Name;
                if (dr[strColumnName] != DBNull.Value)
                {
                    pi.SetValue(instance, dr[strColumnName], null);
                }
            }
            return instance;
        }
    }
}
