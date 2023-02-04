// Задача 41: Пользователь вводит с 
// клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Enter quantity of numbers:");
int size = Convert.ToInt32(Console.ReadLine());

int[] inputArr = InputArray(size);
PrintArray(inputArr);
int naturalNumbers = NaturalNumbers(inputArr);
Console.WriteLine($" -> {naturalNumbers}");

int[] InputArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}
int NaturalNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

