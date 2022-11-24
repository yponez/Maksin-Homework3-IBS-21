using task5;
using Library;


Console.Write("Введите строку: ");
string s = GlobalLiabary.EnterString();

string[] dates = LocalClass5.GetRegexDates(s);
if (dates.Length == 0)
{
    Console.WriteLine("Введена пустая строка или неверный формат");
    return;
}

LocalClass5.PrintDatesInfo(dates);