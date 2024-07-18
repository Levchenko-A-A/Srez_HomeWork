Console.WriteLine("Метод, определяющий простое число:");
Console.Write("Введите число:");
int num;
int.TryParse(Console.ReadLine()!, out num);
if (IsPrime(num)) Console.WriteLine("Число простое.");
else Console.WriteLine("Число не простое");

bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}