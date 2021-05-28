using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Pd4
{
    static class FilePath
    {
        private static string filePathTxt;
        public static void SetFilePathTxt(string value)
        {
            filePathTxt = value;
        } 
        public static string GetFilePathTxt()
        {
            return filePathTxt;
        }
    }
}
