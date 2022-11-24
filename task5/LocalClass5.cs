using System;
using System.IO;
using System.Text.RegularExpressions;

namespace task5
{
    public static class LocalClass5
    {
        public static string[] GetRegexDates(string s)
        {
            string pattern = @"(?<d>0[1-9]|[1-2][0-9]|3[0-1])-(?<m>0[1-9]|1[0-2])-" +
                            @"(?<y>[0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]|[0-9][1-9][0-9]{2}|[1-9][0-9]{3})";
            Regex temp = new Regex(pattern);
            MatchCollection matches = temp.Matches(s);

            string[] dates = new string[matches.Count];

            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    dates[i] = $"{matches[i].Value}:{matches[i].Groups["d"]}:{matches[i].Groups["m"]}:{matches[i].Groups["y"]}";
                }
            }

            return dates;
        }

        public static void PrintDatesInfo(string[] dates)
        {
            for (int i = 0; i < dates.Length; i++)
            {
                string[] info = dates[i].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                string message = $"{info[0]}, день:{info[1]} месяц:{info[2]}, год:{info[3]}";
                Console.WriteLine(message);
            }
        }
    }
}