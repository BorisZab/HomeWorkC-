﻿Console.Clear();
Console.WriteLine("Введите координату  x: ");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату  x: ");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату  z: ");
double xz = Convert.ToDouble(Console.ReadLine());
double yz = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(xz - yz, 2));
Console.WriteLine($"distance between points: {result}");