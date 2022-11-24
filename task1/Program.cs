using Library;
using task1;

Console.Write("Введите строку: ");
string s = GlobalLiabary.EnterString();

string[] mas = LocalClass1.GetSplitterString(s);
double averageLength = LocalClass1.GetAverageWordLength(mas);

Console.WriteLine($"Средняя длинна строки: {averageLength}");
