//27.Найти сумму элементов по диагонали матрицы.
//28. Создать массив массивов
//29. Найти среднее арифметическое для каждого подмассива.
//30. Поменять местами строки в подмассивах.
//31. Найти наибольший и наименьший элементы в каждом подмассиве.

int[][] mas = new int[4][];
mas[0]=new int[4] { 7, -4, 22, -12 };
mas[1]=new int[1] { 1 };
mas[2]=new int[4] { 13, -20, -6, -9 };
mas[3]=new int[3] { 0, 16, 5 };
PrintMasMas(mas);
CalculateAverageMasMas(mas);
MinMaxMasMas(mas);



void PrintMasMas(int[][] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = 0; j < mas[i].Length; j++)
        {
            Console.Write($"{mas[i][j],4} ");
        }
        Console.WriteLine();
    }
}

void CalculateAverageMasMas(int[][] mas)
{
    double result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        result = 0;
        for (int j = 0; j < mas[i].Length; j++)
        {
            result += mas[i][j];
        }
        Console.WriteLine($"Среднее арифметическое {i+1} массива: {result/ mas[i].Length}");
    }
}

void MinMaxMasMas(int[][] mas)
{
    
    for (int i = 0; i < mas.Length; i++)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int j = 0; j < mas[i].Length; j++)
        {
            if (min > mas[i][j]) min = mas[i][j];
            if (max < mas[i][j]) max = mas[i][j];
        }
        Console.WriteLine($"Минимальное  значение в {i + 1} массиве: {min}");
        Console.WriteLine($"Максимальное значение в {i + 1} массиве: {max}");
    }
}