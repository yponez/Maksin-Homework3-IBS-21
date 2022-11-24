using System;
using System.Text;

namespace task2
{
    public static class LocalClass2
    {
        public static string NormalizeString(string str)
        {
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    temp.Append(char.ToLower(str[i]));
                }
            }
            return temp.ToString();
        }
        public static bool IsStringPalindrome(string str)
        {
            // StringBuilder temp = new StringBuilder();
            string temp = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                temp += str[i];//  temp.Append(str[i]);
            }

            return str.Equals(temp.ToString());
        }
    }
}
