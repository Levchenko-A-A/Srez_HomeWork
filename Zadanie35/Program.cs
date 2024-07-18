// 35. Написать локальную функцию для вычисления факториала числа.

Console.Write("Для расчета факториала введите число:");
int number;
int.TryParse(Console.ReadLine(), out number);
Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");

int Factorial(int number)
{
    return number == 0 ? 1 : Factorial(number - 1) * number;
}