// Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Enter the digit:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter degree:");
int degree = Convert.ToInt32(Console.ReadLine());
int result = Degree(number, degree);
int negativResult = Degree(number, degree * -1);

if (degree > 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Incorrect input");
}

int Degree(int arg1, int arg2)
{
    int result = 1;
    for (int i = 0; i < arg2; i++)
    {
        result *= arg1;
    }
    return result;
}
