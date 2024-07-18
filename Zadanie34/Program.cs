//34.Написать локальную функцию для проверки, является ли строка
//палиндромом.

Console.Write("Введите строку:");
string str = Console.ReadLine()!;
if (Polindrom(str)) Console.WriteLine($"Введеная строка является палиндромом.");
else Console.WriteLine($"Введеная строка не является палиндромом.");


bool Polindrom(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != str[str.Length - i - 1]) return false;
    }
    return true;
}