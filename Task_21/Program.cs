// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Random rand = new Random();

int x1 = rand.Next(-100, 101), y1 = rand.Next(-100, 101), z1 = rand.Next(-100, 101);
int x2 = rand.Next(-100, 101), y2 = rand.Next(-100, 101), z2 = rand.Next(-100, 101);

Console.WriteLine($"Point A  ({x1}, {y1}, {z1})");
Console.WriteLine($"Point B  ({x2}, {y2}, {z2})");

double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(Math.Round(length,2));