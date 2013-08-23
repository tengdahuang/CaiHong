using System;
using System.Collections.Generic;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;

namespace ChildCafe.Bll
{
    public class BllUserLogin
    {
        public bool CheckLogin(string name, string password)
        {
            password = XSolo.Common.EncryptDecrypt.MD5(password);
            var recordCount = MainOptr.Find(CK.K["Name"] == name && CK.K["Password"] == password).Count;
            return recordCount >= 1;
        }

        public static MainOptr GetUser(string name)
        {
            var mainoptr = MainOptr.FindOne(CK.K["Name"] == name);

            return mainoptr;
        }
        //public static List<string> GetUserNameList()
        //{
        //    var strs = new List<string>();
        //    var myops = new Select("Name").From("SysOptrs").ExecuteTypedList<SysOptr>();
        //    foreach (SysOptr a in myops)
        //    {
        //        strs.Add(a.Name);
        //    }

        //    return strs;
        //}
        public static List<string> GetUserNameList()
        {
            var strs = new List<string>();
            var myops = MainOptr.FindAll();
            foreach (MainOptr mainOptr in myops)
            {
                strs.Add(mainOptr.Name);
            }
            return strs;
        }
    }
}
