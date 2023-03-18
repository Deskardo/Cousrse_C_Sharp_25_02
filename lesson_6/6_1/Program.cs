// Напишите программу, которая принимает на вход три числа, и проверяет, может ли существовать треугольник, со сторонами такой длины.

void Triangle(int num1, int num2, int num3)
{
if (num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num1 + num2))
  Console.WriteLine("Треугольник возможен");
else
  Console.WriteLine("Треугольник не возможен");
}

Console.WriteLine("Введите сторону A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону B");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону C");
int c = int.Parse(Console.ReadLine()!);

Triangle(a, b, c);