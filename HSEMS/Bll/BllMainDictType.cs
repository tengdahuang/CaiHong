using System.Data;
using HSEMS.Dal;
using Lephone.Data;

namespace HSEMS.Bll
{
    public class BllMainDictType
    {
        public static DataTable GetTable(string optrType)
        {
            if (optrType == "All")
                return MainDictType.FindAll().ToDataTable();
            return MainDictType.Find(CK.K["OptrType"] == optrType).ToDataTable();
        }

        public static void DelCell(long id)
        {
            MainDictType.DeleteAll(CK.K["Id"] == id);
        }
    }
}