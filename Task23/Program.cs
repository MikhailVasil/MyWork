Console.WriteLine("Enter the digit:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) Console.WriteLine("Invalid input");
else Cube(number);

void Cube(int number)
{
    int n = 1;
    while (n <= number)
    {
        Console.WriteLine($"{n,3} {n * n * n,6}");
        n++;
    }
}