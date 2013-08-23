using System;
using System.Collections.Generic;
using System.Text;
using ChildCafe.Dal;
using Lephone.Data;
using Lephone.Data.SqlEntry;

namespace ChildCafe.Common
{
    class CommonStatics
    {
        public static List<MainDict> GetDict(string optrType, string dictType)
        {
            MainDict md = MainDict.New;
            md.Id = 0;
            md.Name = "";

            List<MainDict> mainDicts = MainDict.Find(CK.K["OptrType"] == optrType && CK.K["DictType"] == dictType);
            mainDicts.Insert(0, md);
            return mainDicts;

        }
    }
}
