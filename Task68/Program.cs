
// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Enter two non-negative numbers : ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 && n >= 0)
{
    int num = AkkermanFunktion(m, n);
    Console.WriteLine($"{num}");
}
else
{
    Console.WriteLine("Incorrect input");
}

int AkkermanFunktion(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunktion(m - 1, 1);
    else
    {
        n = AkkermanFunktion(m, n - 1);
        return AkkermanFunktion(m - 1, n);
    }
}


