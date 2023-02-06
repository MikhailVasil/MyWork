﻿// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7     -2    -0,2
// 1    -3,3    8    -9,9
// 8     7,8   -7,1   9

double[,] CreateMatrixRndDouble(int rows, int column, int min, int max)
{
    double[,] matrix = new double[rows, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * 
            (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],5} | ");
            else 
                Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}
Console.WriteLine("enter the height of the matrix: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the length of the matrix: ");
int length = Convert.ToInt32(Console.ReadLine());

if (height > 0 && length > 0)
{
    double[,] newMatrix = CreateMatrixRndDouble(height, length, -10, 10);
    PrintMatrix(newMatrix);
}
else Console.WriteLine("Incorrect input");