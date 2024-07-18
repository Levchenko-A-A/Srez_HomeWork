//Напишите программу, которая находит сумму двух чисел, введенных
//пользователем, и выводит результат на экран.

Console.Write("Введите первое число:");
double n;
double.TryParse(Console.ReadLine()!, out n);
Console.Write("Введите второе число:");
double m;
double.TryParse(Console.ReadLine()!, out m);
Console.WriteLine($"Сумма двух чисел = {n+m}");