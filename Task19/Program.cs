// Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter palindrome: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0 || number > 2000000000)
{
    Console.WriteLine("Input Error");
}
else
{
    Equality(number, MirrorDigit(number));
}

int MirrorDigit(int num)
{
    int mirror = 0;
    while (num != 0)
    {
        int last = num % 10;
        mirror = mirror * 10 + last;
        num /= 10;
    }
    return mirror;

}

void Equality(int arg1, int arg2)
{
    if (arg1 == arg2)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
