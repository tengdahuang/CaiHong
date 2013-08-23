using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace XSolo.Common
{
    public class EncryptDecrypt
    {
        public EncryptDecrypt()
        {

        }

        private static string encryptkey = "HShs";    //密钥  

        #region   对数据进行加密
        /// <summary>
        /// 对数据进行加密
        /// </summary>
        /// <param name="encryptstring">需要加密的数据</param>
        /// <returns></returns>
        public static string DESEncrypt(string encryptstring)
        {
            string strRtn;
            try
            {
                DESCryptoServiceProvider desc = new DESCryptoServiceProvider();//des进行加密
                byte[] key = System.Text.Encoding.Unicode.GetBytes(encryptkey);
                byte[] data = System.Text.Encoding.Unicode.GetBytes(encryptstring);
                MemoryStream ms = new MemoryStream();//存储加密后的数据
                CryptoStream cs = new CryptoStream(ms, desc.CreateEncryptor(key, key), CryptoStreamMode.Write);
                cs.Write(data, 0, data.Length);//进行加密
                cs.FlushFinalBlock();
                strRtn = Convert.ToBase64String(ms.ToArray());
                return strRtn;
            }

            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message, "错误消息提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region   对数据进行解密
        /// <summary>
        /// 对数据进行解密
        /// </summary>
        /// <param name="decryptstring">需要解密的数据</param>
        /// <returns></returns>
        public static string DESDecrypt(string decryptstring)
        {
            string strRtn;
            try
            {
                DESCryptoServiceProvider desc = new DESCryptoServiceProvider();
                byte[] key = System.Text.Encoding.Unicode.GetBytes(encryptkey);
                byte[] data = Convert.FromBase64String(decryptstring);
                MemoryStream ms = new MemoryStream();//存储解密后的数据
                CryptoStream cs = new CryptoStream(ms, desc.CreateDecryptor(key, key), CryptoStreamMode.Write);
                cs.Write(data, 0, data.Length);//解密数据
                cs.FlushFinalBlock();
                strRtn = System.Text.Encoding.Unicode.GetString(ms.ToArray());
                return strRtn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message, "错误消息提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion


        #region MD5加密
        public static string MD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] originalBytes = Encoding.UTF8.GetBytes(text);
            byte[] computedBytes = md5.ComputeHash(originalBytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in computedBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        #endregion MD5加密结束
    }


}
