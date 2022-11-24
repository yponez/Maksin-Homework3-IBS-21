using System;
using System.Text.RegularExpressions;

namespace task3
{
    public static class LocalClass
    {
        internal static bool StringIsEmail(string s)
        {
            string pattern = @"(?:^[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?)@" +
                             @"(?:[a-zA-Z0-9](?:[a-zA-Z0-9\-_]*[a-zA-Z0-9])?\.)+(?:[a-zA-Z]{2,6})$";

            if (Regex.IsMatch(s, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}