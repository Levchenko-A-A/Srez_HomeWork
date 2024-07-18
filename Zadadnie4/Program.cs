//Напишите программу, которая определяет, является ли введенное
//пользователем число четным или нечетным.

Console.Write("Введите число:");
int a;
int.TryParse(Console.ReadLine(), out a);
if (IsEven(a)) Console.WriteLine("Число четное.");
else Console.WriteLine("Число нечетное");

bool IsEven(int number)
{
    if (a % 2 == 0) return true;
    else return false;
}