// Задача 43: Напишите программу, 
// которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double SearchX(double b11, double b22, double k11, double k22)
{
    double x1 = (b22 - b11) / (k11 - k22);
    return x1;
}
double SearchY(double x, double k11, double b11)
{
    double y1 = k11 * x + b11;
    return y1;
}
Console.Write("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine("parallel lines");
else
{
    double x = SearchX(b1, b2, k1, k2);
    double xRound = Math.Round(x, 2, MidpointRounding.ToZero);

    double y = SearchY(x, k1, b1);
    double yRound = Math.Round(y, 2, MidpointRounding.ToZero);

    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({xRound}; {yRound})");
}