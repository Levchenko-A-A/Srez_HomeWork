// Напишите программу, которая находит наименьшее число из трех
//введенных пользователем чисел и выводит его на экран.

Console.Write("Введите первое число:");
int[] mas = new int[3];
int.TryParse(Console.ReadLine(), out mas[0]);
Console.Write("Введите второе число:");
int.TryParse(Console.ReadLine(), out mas[1]);
Console.Write("Введите третье число:");
int.TryParse(Console.ReadLine(), out mas[2]);
Console.WriteLine($"Наименьшее число из трех: {mas.Min()}");