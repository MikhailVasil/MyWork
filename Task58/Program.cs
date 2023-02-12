// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductMatrix(int[,] matrixFirst, int[,] matriSxecond)
{
    int[,] finalMatrix = new int[matrixFirst.GetLength(0), matriSxecond.GetLength(1)];
    int length = matrixFirst.GetLength(1);
    if (matrixFirst.GetLength(1) < matriSxecond.GetLength(0)) length = matriSxecond.GetLength(0);

    for (int i = 0; i < finalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < length; k++)
            {
                finalMatrix[i, j] += matrixFirst[i, k] * matriSxecond[k, j];
            }
        }
    }

    return finalMatrix;
}

int[,] firstMatrix = CreateMatrixRndInt(4, 4, 1, 3);
int[,] secondMatrix = CreateMatrixRndInt(4, 4, 1, 4);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] productMatrix = ProductMatrix(firstMatrix, secondMatrix);
    Console.WriteLine($"Resulting matrix");
    PrintMatrix(productMatrix);
}
else
{
    Console.WriteLine("These matrices cannot be multiplied");
}