// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("Enter the digit");
int number = Convert.ToInt32(Console.ReadLine());

int result = Sum(number);

if (number >= 0)
{
    Console.WriteLine($"Sum = {result}");
}
else if (number < 0)
{
    Console.WriteLine($"Sum = {result * -1}");
}
else
{
    Console.WriteLine("Incorrect input");
}

int Sum(int num)
{
    int lastNumber = 0;
    int sum = 0;
    while (num != 0)
    {
        lastNumber = num % 10;
        sum += lastNumber;
        num /= 10;
    }
    return sum;
}

