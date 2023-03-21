Console.WriteLine("введите значение x1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение x2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число y2");
double y2 = Convert.ToInt32(Console.ReadLine());

double x = (-x2 + x1)/(-y1 + y2);
double y = y2 * x + x2;



Console.WriteLine($"Точка пересечения X:{x} Y:{y}");