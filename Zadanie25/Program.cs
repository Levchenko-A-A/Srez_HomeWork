//25. Создайте двумерный массив длиной 5х5 элементов, вручную
//заполните его числами от -10 до 10.
//26. Вычислить сумму элементов в каждой строке

int[,] mas = new int[5,5];
RandMasTwo(mas);
PrintMasTwo(mas);
SumLineMasTwo(mas);
SumDiagonalMasTwo(mas);


void RandMasTwo(int[,] mas)
{
    Random random = new Random();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(0, 11);
        }
    }
}
void PrintMasTwo(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{ mas[i, j],4} ");
        }
        Console.WriteLine();
    }
}
void SumLineMasTwo(int[,] mas)
{
    int result=0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            result += mas[i, j];
        }
        Console.WriteLine($"Сумма элементов в строке {i+1} = {result}");
    }
}
void SumDiagonalMasTwo(int[,] mas)
{
    int result = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        result += mas[i, i]+mas[i, mas.GetLength(1)-1-i];
    }
    Console.WriteLine($"Сумма диагоналей: {result}");
}