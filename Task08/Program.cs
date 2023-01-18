Console.WriteLine("Enter N:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (number > 0)
{
    while (i <= number)
    {
        Console.Write($"{i} ");
        i += 2;
    }
}
else
{
    Console.Write("You entered a number < 0 ");
}