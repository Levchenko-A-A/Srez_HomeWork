//Напишите программу, которая находит все простые числа от 1 до 100
//и выводит их на экран.

Console.WriteLine("Список простых чисел от 1 до 100:");
for (int i = 1; i <= 100; i++)
{
    if(IsPrime(i)) Console.WriteLine(i);
}

bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}