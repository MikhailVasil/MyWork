// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}
void ElementMatrixSerch(int[,] matrix, int height, int length)
{
    if (height >= 0 && height < matrix.GetLength(0) 
     && length >= 0 && length < matrix.GetLength(1))
     {
        Console.WriteLine($"{height}, {length} -> {matrix[height, length]}");  
     }
     else 
     {
        Console.WriteLine("This element is not in the matrix");
     }
}

int[,] newMatrix = CreateMatrixRndInt(4, 4, -10, 10);
Console.WriteLine("Enter matrix element index:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
ElementMatrixSerch(newMatrix, x, y);
Console.WriteLine();
PrintMatrix(newMatrix);






