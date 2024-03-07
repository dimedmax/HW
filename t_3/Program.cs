// Задайте произвольную строку. Выясните, является ли она палиндромом.

string originalString = "Hello";
bool isPalindrom = true;

for (int i = 0; i < originalString.Length / 2; i++)
{
    if (originalString[i] != originalString[originalString.Length - 1 - i])
    {
        isPalindrom = false;
        break;
    }
}

if (isPalindrom)
{
    Console.WriteLine("Строка является палиндромом.");
}
else
{
    Console.WriteLine("Строка не является палиндромом.");
}
