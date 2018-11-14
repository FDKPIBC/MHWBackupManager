using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MHWBackup
{
    public static class ExtendHelper
    {
        public static bool IsEmpty(this string preString)
        {
            return string.IsNullOrEmpty(preString);
        }

        public static bool PathIsExist(this string path)
        {
            return Directory.Exists(path);
        }

        public static bool IsAllNumber(this string dirName)
        {
            return Regex.IsMatch(dirName, "(^[0-9]*$)");
        }

        public static string GetDirName(this string dirPath)
        {
            return dirPath.Substring(dirPath.LastIndexOf('\\') + 1);
        }

        /// <summary>
        /// 替换并去空(似乎部分时候无卵用?)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="replaceStr"></param>
        /// <param name="replaceTo"></param>
        /// <returns></returns>
        public static string ReplaceAndTrim(this string str,string replaceStr,string replaceTo)
        {
            return str.Replace(replaceStr, replaceTo).Replace("\n", "").Trim();
        }

        /// <summary>
        /// 替换并去空
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceAndTrim(this string str)
        {
            return str.Replace("\n", "").Trim();
        }

        /// <summary>
        /// 游戏目录
        /// </summary>
        /// <param name="baseDir"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ToGameDictionary(this string baseDir)
        {
            var gd = new Dictionary<string, string>();
            foreach (var dir in Directory.GetDirectories(baseDir))
            {
                var dirName = dir.Substring(dir.LastIndexOf('\\')+1);
                if (!dirName.IsAllNumber()) continue;
                gd.Add(dirName,dir);
            }
            return gd;
        }

        /// <summary>
        /// 获取SHA1值
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetSHA1(this string path)
        {
            if (!File.Exists(path)) return string.Empty;
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                var shaByte = sha1.ComputeHash(file);
                var result = string.Join("",shaByte.Select(t => t.ToString("x2")));
                return result.ToUpper();
            }

        }
    }
}
