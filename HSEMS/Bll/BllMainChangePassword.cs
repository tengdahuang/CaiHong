using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HSEMS.Dal;
using HSEMS.Common;
using XSolo.Common;

namespace HSEMS.Bll
{
    public class BllMainChangePassword
    {
        public static bool CheckOldPass(long id, string pass )
        {

            MainOptr mo = MainOptr.FindById(id);
            MessageBox.Show(UserStatics.OptrId + " " + EncryptDecrypt.MD5(pass) + " " + mo.Password);
            if (EncryptDecrypt.MD5(pass) == mo.Password)
                return true;
            return false;
        }

        public static void SaveNewPass(long id, string pass)
        {
            MainOptr mo = MainOptr.FindById(id);
            mo.Password = EncryptDecrypt.MD5(pass);
            mo.Save();
        }
    }
}
