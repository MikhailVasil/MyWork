// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter two natural numbers : ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1)
{
    Console.WriteLine("Incorrect input");
}
else if (number1 == number2)
{
    Console.WriteLine($"M = {number1}; N = {number2} -> 0");
}
else
{
    int sum = SumNumbers(number1, number2);
    Console.WriteLine($"M = {number1}; N = {number2} -> {sum}");
}

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num1 < num2) return num1 += SumNumbers(num1 + 1, num2);
    else return num1 += SumNumbers(num1 - 1, num2);
}