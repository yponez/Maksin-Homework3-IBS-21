using task2;
using Library;


Console.Write("Введите строку: ");
string s = GlobalLiabary.EnterString();

s = LocalClass2.NormalizeString(s);

if (LocalClass2.IsStringPalindrome(s))
{
    Console.WriteLine("Строка является полиндромом");
}
else
{
    Console.WriteLine("Строка не является полиндромом");
}