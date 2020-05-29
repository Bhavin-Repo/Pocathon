using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TeamsDevOpsComms.Model;

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

        public static ADOItem GetADOItemDetails(string message)
        {
            String[] sentenceList = message.Split('\n');
            String[] wordList = message.Split('|');
            String[] wordList1 = message.Split(' ');

            ADOItem adoItem = new ADOItem();

            adoItem.Title = wordList[3].Trim();
            adoItem.Status = wordList[0].Trim();
            for (int i = 0; i < wordList.Length; i++)
            {
                if ((wordList[i].Trim().StartsWith("P") || wordList[i].Trim().StartsWith("p")) && wordList[i].Trim().Length == 2)
                {
                    adoItem.Priority = wordList[i].ToUpper();
                }

                switch (wordList[i].Trim())
                {
                    case "SR":
                        adoItem.Type = type.SR;
                        break;
                    case "W":
                        adoItem.Type = type.W;
                        break;
                    case "Q":
                        adoItem.Type = type.Q;
                        break;
                    case "O":
                        adoItem.Type = type.O;
                        break;
                    case "incident":
                        adoItem.Type = type.incident;
                        break;
                }

            }

            for (int i = 0; i < wordList1.Length - 1; i++)
            {
                Regex r = new Regex("^[CS0-9]*$");
                if (r.IsMatch(wordList1[i].Trim()) && wordList1[i].Trim().Length >= 6)
                {
                    adoItem.CustomerReferenceNumber = wordList1[i].Trim();
                }
            }

            adoItem.Module = wordList[2].Trim();

            for (int i = 2; i < sentenceList.Length; i++)
            {
                adoItem.Discription += sentenceList[i] + '\n';
            }

            return adoItem;
        }
    }
}
