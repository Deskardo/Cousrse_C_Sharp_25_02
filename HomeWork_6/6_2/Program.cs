// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1
// y = k2 * x + b2
// значения b1, k1, b2 и k2 задаются пользователем


void IntersectionPoint(double b1, double k1, double b2, double k2)
{
  double x = 0;
  double y = 0;
 // уравнение k1 * x + b1 = k2 * x + b2 => x = (b2 - b1) / (k1 - k2)
 // y = y = num1 * x + num2
  if(k1 == k2 && b1 == b2)
  {
    Console.WriteLine("Прямые лежат друг на друге");
  }
  else if(k1 == k2)
  {
    Console.WriteLine("Прямые параллельны");
  }
  else
  {
    x = - (b1 - b2) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в координатах (x:{x}; y:{y})");
  }
}

Console.WriteLine("Введите переменную b1");
double b3 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите переменную k1");
double k3 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите переменную b2");
double b4 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите переменную k2");
double k4 = double.Parse(Console.ReadLine()!);

IntersectionPoint(b3, k3, b4, k4);