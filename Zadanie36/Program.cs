// 36. Создать локальную функцию для нахождения наибольшего общего
//делителя двух чисел.

Console.Write("Введите первое число:");
long a;
long.TryParse(Console.ReadLine(), out a);
Console.Write("Введите второе число:");
long b;
long.TryParse(Console.ReadLine(), out b);

long gcd = GetGCD(a, b);
long lcm = a * b / gcd;

Console.WriteLine($"\nНОД равен {gcd}\nНОК равен {lcm}");


long GetGCD(long a, long b)
{
    if (a == 0)
    {
        return b;
    }

    if (b == 0)
    {
        return a;
    }

    if (a > b) return GetGCD(a % b, b);
    else return GetGCD(a, b % a);
}