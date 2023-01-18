Console.WriteLine("Enter number : ");
int number1 = Convert.ToInt32 (Console.ReadLine());

if (number1 == 0)
{
    Console.WriteLine($"You entered {number1}");
}
else if (number1 % 2 == 0)
{
    Console.WriteLine($"{number1} is even");
}
else 
{
    Console.WriteLine($"{number1} is not even");
}