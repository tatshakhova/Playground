Console.WriteLine("Введите координаты x точки a");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y точки a");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z точки a");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x точки b");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y точки b");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z точки b");
int bz = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.WriteLine($"Расстояние между двумя точками равно {dist}");