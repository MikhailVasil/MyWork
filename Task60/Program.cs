// *Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateThreeDArrayRndInt(int array, int rows, int column)
{
    int count = 100;
    int[,,] threeDArray = new int[array, rows, column];
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                threeDArray[i, j, k] = count;
                count++;
            }  
            count = count -1;
            count++;  
        }
        count = count -1;
        count++;
    }
    return threeDArray;
}

void PrintThreeDArray(int[,,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                Console.Write($" {threeDArray[i, j, k],1} ({i},{j},{k})");

            }
        }
    }
}

int[,,] threeDArray = CreateThreeDArrayRndInt(3,3,3);
PrintThreeDArray(threeDArray);