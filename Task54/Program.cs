// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int column, int min, int max)
{
    int[,] matrix = new int[rows, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],3} | ");
            else
                Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

void SortingMatrixRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = matrix.GetLength(1) - 1; k > j; k--)
            {
                if (matrix[i, k] > matrix[i, k - 1])
                {
                    int tmp = matrix[i, k];
                    matrix[i, k] = matrix[i, k - 1];
                    matrix[i, k - 1] = tmp;
                }
            }
        }
    }
}

int[,] createMatrix = CreateMatrixRndInt(5, 4, 0, 9);
PrintMatrix(createMatrix);
Console.WriteLine();
SortingMatrixRows(createMatrix);
PrintMatrix(createMatrix);
