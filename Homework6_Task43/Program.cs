﻿Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
 
double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;
 
Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
//b1 = 2, k1 = 5, b2 = 4, k2 = 9