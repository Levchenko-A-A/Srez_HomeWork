using Z40;

Console.WriteLine("Для матрицы N*M");
Console.Write("Введите N: ");
int n;
int.TryParse(Console.ReadLine(), out n);
Console.Write("Введите M: ");
int m;
int.TryParse(Console.ReadLine(), out m);
int[,] matrixOne = new int[n, m];
int[,] matrixTwo = new int[n, m];
Matrix matrix = new Matrix();
matrix.RandomMatrix(matrixOne);
matrix.RandomMatrix(matrixTwo);
matrix.PrintMatrix(matrixOne);
matrix.PrintMatrix(matrixTwo);
matrix.SumMatrix(matrixOne, matrixTwo);

Console.WriteLine("\nРезультат умножения матриц:\n");
try
{
    matrix.PrintMatrix(Matrix.MulMatrix(matrixOne, matrixTwo));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("\nТранспонированые матрицы:");
try
{
    Console.WriteLine("\nПервая матрица:");
    matrix.PrintMatrix(matrix.TranspMatrix(n, m, matrixOne));
    Console.WriteLine("\nВторая матрица:");
    matrix.PrintMatrix(matrix.TranspMatrix(n, m, matrixTwo));
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}