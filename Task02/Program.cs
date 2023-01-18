Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Max = {number1}");
}
else 
{
    Console.WriteLine($"Max = {number2}");
}