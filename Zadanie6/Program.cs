//Напишите программу, которая вычисляет факториал введенного
//пользователем числа и выводит результат на экран.

Console.Write("Для расчета факториала введите число:");
int number;
int.TryParse(Console.ReadLine(), out number);
Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");

int Factorial(int number)
{
    return number == 0 ? 1 : Factorial(number - 1) * number;
}