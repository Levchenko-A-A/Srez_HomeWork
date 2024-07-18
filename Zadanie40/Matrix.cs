
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Z40
{
    internal class Matrix
    {
        public void RandomMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 101);
                }
            }
        }
        public void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6}");
                }
                Console.WriteLine();
            }
        }
        public void SumMatrix(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.Length == matrix2.Length)
            {
                Console.WriteLine();
                Console.WriteLine("Результат сложения матриц:");
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        Console.Write($"{matrix1[i, j] + matrix2[i, j],4}");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static int[,] MulMatrix(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                int[,] temp = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix2.GetLength(0); k++)
                        {
                            temp[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                return temp;
            }
            else throw new Exception("Матрицы нельзя перемножить");
        }
        public int[,] TranspMatrix(int n, int m, int[,] matrix)
        {
            int[,] temp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp[i, j] = matrix[j, i];
                }
            }
            return temp;
        }
    }
}
