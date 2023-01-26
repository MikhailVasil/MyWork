// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Enter the coordinates of the first point:");
Console.Write("X1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinates of the second point:");
Console.Write("X2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1, x2, y1, y2, z1, z2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Distance between points: {distanceRound}");

double Distance(int a1, int a2, int b1, int b2, int c1, int c2)
{
    double result = Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2) + Math.Pow((c1 - c2), 2));
    return result;
}