using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

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
    }
}
