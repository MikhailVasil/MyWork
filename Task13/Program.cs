// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
//(целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
{
    number = number / 10;

}
if (number < 0)
{
    number = number * (-1);
}
if (number > 99 && number <= 999)
{

    number = number % 10;
    Console.WriteLine($"Third digit = {number}");
}
else
{
    Console.WriteLine("No third digit");
}