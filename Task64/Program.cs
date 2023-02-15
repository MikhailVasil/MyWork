// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void NaturNumbers(int n)
{
    Console.Write($"{n}");
    if (n == 1) return;
    if (n > 1) Console.Write(", ");
    NaturNumbers(n - 1);
}
Console.WriteLine("Enter a natural number : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.Write($"N = {number} -> \"");
    NaturNumbers(number);
    Console.Write("\"");
}
else
{
    Console.WriteLine("Incorrect input");
}


