// *Задача 62. Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int rows, int column)
{
    int count = 1;
    int[,] matrix = new int[rows, column];
    int row = 0;
    int col = 0;
    while (row < rows && col < column)
    {
        for (int i = col; i < column; i++)
        {
            matrix[row, i] = count++;
        }
        row++;
        for (int i = row; i < rows; i++)
        {
            matrix[i, column - 1] = count++;
        }
        column--;
        if (row < rows)
        {
            for (int i = column - 1; i >= col; i--)
            {
                matrix[rows - 1, i] = count++;
            }
            rows--;
        }
        if (col < column)
        {
            for (int i = rows - 1; i >= row; i--)
            {
                matrix[i, col] = count++;
            }
            col++;
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

int[,] spiralMatrix = CreateSpiralMatrix(7, 6);

PrintMatrix(spiralMatrix);