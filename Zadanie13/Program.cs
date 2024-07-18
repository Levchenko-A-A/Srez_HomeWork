//Напишите программу, которая определяет, является ли введенное
//пользователем число палиндромом (читается одинаково слева направо
//и справа налево).

using System.Threading.Channels;

Console.Write("Введите число:");
int num;
int.TryParse(Console.ReadLine()!, out num);
string str = num.ToString();
if (Polindrom(str)) Console.WriteLine($"Введеное число {num} является палиндромом.");
else Console.WriteLine($"Введеное число {num} не является палиндромом.");


bool Polindrom(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != str[str.Length-i-1]) return false;
    }
    return true;
}