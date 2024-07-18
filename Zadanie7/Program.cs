//Напишите программу, которая находит сумму всех чисел от 1 до 100 и
//выводит результат на экран.

Console.Write("Введите первое число:");
int a;
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите второе число:");
int b;
int.TryParse(Console.ReadLine(), out b);
int sum = 0;
Console.WriteLine($"Сумма чисел от {a} до {b} = {RecSum(a,b)}");

int RecSum(int a, int b)
{
    if (a <= b)
    {
        sum = sum+a;
        a++;
        RecSum(a, b);
    }
    return sum;
}