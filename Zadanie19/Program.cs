//Напишите программу, которая считывает числа с клавиатуры, пока
//пользователь не введет отрицательное число, и выводит сумму
//введенных положительных чисел на экран.

double sum = 0;
do 
{
    Console.WriteLine("Введите число, для выхода введите отртцательное число:");
    double number;
    double.TryParse(Console.ReadLine()!, out number);
    if (number > 0)
    {
        sum = sum + number;
        Console.WriteLine($"сумма чисел: {sum}");
    }
    else break;
}
while (true);