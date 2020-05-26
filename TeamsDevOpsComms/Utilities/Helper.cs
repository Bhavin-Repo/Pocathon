using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TeamsDevOpsComms.Utilities
{
   public static class Helper
    {
        /// <summary>
        /// Removes all HTML tags from the strings
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ConvertHtmlToPlainText(object obj)
        {
            string result = "";
            Regex regex = new Regex("\\<[^\\>]*\\>");
            result = regex.Replace(obj.ToString(), String.Empty);
            return result;
        }
    }
}
