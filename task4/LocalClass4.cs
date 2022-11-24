using System;
using System.Text;
using System.Text.RegularExpressions;

namespace task4
{
    public static class LocalClass4
    {
        public static string ReplaceRegexTags(string s)
        {
            string pattern = @"(\<([^\>]+)\>)";
            string target = "_";

            Regex regex = new Regex(pattern);

            return regex.Replace(s, target);
        }

        public static string NoRegexReplaceTags(string str)
        {
            StringBuilder temp = new StringBuilder();
            int index = 0;

            while (true)
            {
                int indexFist = str.IndexOf("<", index);
                int indexSecond = str.IndexOf(">", index);
                if (indexFist == -1 || indexSecond == -1)
                {
                    temp.Append(str.Substring(index, str.Length - index));
                    break;
                }
                "wwww <www> wwww </www> wwww"
                temp.(str.Substring(index, indexFist - index) + "_");
                index = indexSecond + 1;
            }

            return temp.ToString();
        }
    }
}