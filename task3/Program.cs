using task3;
using Library;

Console.Write("Введите электронную почту: ");
string s = GlobalLiabary.EnterString();

if (LocalClass.StringIsEmail(s))
{
    Console.WriteLine("Введена элетронная почта" );
}
else
{
    Console.WriteLine($"Введена не элетронная почта или неверный формат");
}

Console.ReadKey();