// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру 
// этого числа. Выполнить с помощью числовых 
// операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999)
{
    Console.WriteLine("Enter a three-digit number: ");
    number = Convert.ToInt32(Console.ReadLine());
}
// if (number > 99 && number <= 999)
// {
    number = number / 10;
    number = number % 10;
    Console.WriteLine($"Second digit = {number}");
// 5}
