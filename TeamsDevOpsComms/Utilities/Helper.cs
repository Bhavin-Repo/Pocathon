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
        /// Removes all HTML tags from the strings including lines containing only white spaces.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ConvertHtmlToPlainText(object obj)
        {
            string result = "";
            Regex regex = new Regex("\\<[^\\>]*\\>");
            result = Regex.Replace((regex.Replace(obj.ToString(), String.Empty).Replace("&nbsp;", String.Empty).Replace("&lt;", String.Empty).Replace("&gt", string.Empty).Replace("amp;", String.Empty)),
                    @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            return result;
        }
    }
}
