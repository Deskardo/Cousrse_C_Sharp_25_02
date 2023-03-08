// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Example(double x1, double y1, double z1, double x2, double y2, double z2)
{
  return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.WriteLine("Введите x1");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z1");
double c = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите x2");
double d = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2");
double e = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z2");
double f = double.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(Example(a,b,c,d,e,f),2));