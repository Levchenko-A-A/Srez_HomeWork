// Напишите программу, которая определяет, является ли введенное
// пользователем число совершенным (сумма всех делителей числа равна
// самому числу).


Console.Write("Введите число:");
int num;
int.TryParse(Console.ReadLine()!, out num);
if (CheckNumber(num)) Console.WriteLine($"{num} является совершенным числом");
else Console.WriteLine($"{num} не является совершенным числом");

bool CheckNumber(int num)
{
    int sum = 1; 
    for (int i = 2; i < num / 2 + 1; i++) if (num % i == 0) sum += i;   
    return (sum == num);                                                
                                                                        
}