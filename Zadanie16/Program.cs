//Напишите программу, которая находит сумму всех четных чисел от 1
//до 100 и выводит результат на экран.

using System.Diagnostics.CodeAnalysis;

int result = 0;
for (int i = 1; i <+ 100; i++)
{
    if (IsEven(i)) result += i;
}
Console.WriteLine($"Сумма всех четных чисел от 1 до 100: {result}");

bool IsEven(int number)
{
    if (number % 2 == 0) return true;
    else return false;
}