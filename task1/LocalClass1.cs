using System;

namespace task1
{
    public static class LocalClass1
    {
        public static string[] GetSplitterString(string str)
        {
            return str.Split(new char[] { ' ', ',', ':', '.', '!', '?', '-', '(', ')', '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static double GetAverageWordLength(string[] mass)
        {
            int WordLength = 0;

            foreach (string str in mass)
            {
                WordLength += str.Length;
            }

            if (mass.Length > 0)
            {
                return (double)WordLength / mass.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}