Console.WriteLine("Введите координаты 2 точек в 3-ёх мерном пространстве");
Console.WriteLine("Введите координаты точки 1 по x");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 1 по y");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 1 по z");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2 по x");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2 по y");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2 по z");
int Z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(X1, Y1, Z1, X2, Y2, Z2);

Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
double sumSquare = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)+(z2 - z1)*((z2 - z1)));
double res = Math.Sqrt(sumSquare);
return res;
}