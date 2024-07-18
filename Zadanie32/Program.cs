Console.Write("Введите первое число:");
double n;
double.TryParse(Console.ReadLine()!, out n);
Console.Write("Введите второе число:");
double m;
double.TryParse(Console.ReadLine()!, out m);
PrintMul(n, m);


void PrintMul(double n, double m)
{
    Console.WriteLine($"Произведение двух чисел = {n * m}");
}