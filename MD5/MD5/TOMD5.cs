using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToMD5
{
    /// <summary>
    /// 用于将普通字符串进行MD5加密
    /// </summary>
    class ToMD5
    {
        /// <summary>
        /// 将源字符串进行MD5加密
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <returns>加密后的字符串</returns>
        public static String getMD5(String str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();            
            return BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(str)), 4, 8).Replace("-","");
        }
    }
}
