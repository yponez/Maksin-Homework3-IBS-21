namespace Library
{
    public class GlobalLiabary
    {

        public static string EnterString()
        {
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                Console.Write("Введена пустая строка");
                Environment.Exit(0);
            }
            return str;
        }
    }
}
