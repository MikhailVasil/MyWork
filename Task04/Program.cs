Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32 (Console.ReadLine());
int tmp = number1;

if (number2 > tmp)
{
    tmp = number2;
}
if (number3 > tmp)
{
    tmp = number3;
}   
Console.WriteLine($"Max = {tmp}");
