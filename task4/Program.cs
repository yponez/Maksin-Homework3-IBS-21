using task4;
using Library;


Console.Write("Введите строку: ");
string s = GlobalLiabary.EnterString();

string b = LocalClass4.NoRegexReplaceTags(s);
Console.WriteLine("Строка до изменений: " + s);

s = LocalClass4.ReplaceRegexTags(s);
Console.WriteLine("Строка после изменений: " + b);

Console.ReadKey();