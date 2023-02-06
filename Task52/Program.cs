// Задача 52. Задайте двумерный массив из 
// целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое 
// каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AverageRowsMatrix(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] += matrix[i, j];
        }
        array[j] = array[j] / (matrix.GetLength(0));
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Arithmetic mean of each column:");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($" {Math.Round(array[i], 1, MidpointRounding.AwayFromZero)}; ");

        else 
            Console.Write($"  {Math.Round(array[i], 1, MidpointRounding.AwayFromZero)}");
    }
}

int[,] createMatrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(createMatrix);
double[] averageRows = AverageRowsMatrix(createMatrix);
PrintArray(averageRows);