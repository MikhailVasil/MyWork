// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в 
// каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

int[] SummElementsRow(int[,] matrix)
{
    //int size = matrix.GetLength(0);
    //if (matrix.GetLength(0)<matrix.GetLength(1)) size = matrix.GetLength(1);
    int[] sumElemRowArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElemRowArray[i] += matrix[i, j];
        }
    }
    return sumElemRowArray;
}

int SearchMinIndexArray(int[] array)
{
    int minElement = array[0];
    int min = 0;
    for (int i = 1; i < array.Length; i++) 
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
            min = i;
        }
    }
    return min;
}
int[,] createMtrix = CreateMatrixRndInt(3, 3, 0, 9);
PrintMatrix(createMtrix);
int[] newArray = SummElementsRow(createMtrix);
int minIndex = SearchMinIndexArray(newArray);
Console.WriteLine($"Row index on minimum sum {minIndex}");