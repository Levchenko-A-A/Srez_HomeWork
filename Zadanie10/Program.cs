//10.Напишите программу, которая находит среднее арифметическое
//трех чисел, введенных пользователем, и выводит результат на экран.

Console.WriteLine("Метод - среднее арифметическое:");
Console.Write("Введите первое число:");
double[] mas = new double[3];
double.TryParse(Console.ReadLine(), out mas[0]);
Console.Write("Введите второе число:");
double.TryParse(Console.ReadLine(), out mas[1]);
Console.Write("Введите третье число:");
double
    .TryParse(Console.ReadLine(), out mas[2]);
Console.WriteLine($"\nСреднее арифметическое: {CalculateAverage(mas):F2}\n");

double CalculateAverage(double[] mas)
{
    double result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        result += mas[i];
    }
    return result / mas.Length;
}