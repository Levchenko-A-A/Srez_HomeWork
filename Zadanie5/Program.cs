// Напишите программу, которая находит наибольшее число из трех
//введенных пользователем чисел и выводит его на экран.

Console.Write("Введите первое число:");
int a;
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите второе число:");
int b;
int.TryParse(Console.ReadLine(), out b);
Console.Write("Введите третье число:");
int c;
int.TryParse(Console.ReadLine(), out c);

if (a > b && a > c) Console.WriteLine($"Наибольшее число {a}");
else if (b > a && b > c) Console.WriteLine($"Наибольшее число {b}");
else Console.WriteLine($"Наибольшее число {c}");