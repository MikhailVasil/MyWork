// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double FindDiffNumber(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        else if (array[i] < minNumber) minNumber = array[i];
    }
    diff = maxNumber - minNumber;
    return diff;
}

double[] createArray = CreateArrayRndDouble(10, 0, 10);
PrintArrayDouble(createArray);
double diffNumber = FindDiffNumber(createArray);
Console.WriteLine($" -> {diffNumber}");