// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int a = int.Parse(Console.ReadLine()!);

while (a < 100 || a > 1000)
{
  Console.WriteLine("Число не является трёхзначным, введите трёхзначное число");
  a = int.Parse(Console.ReadLine()!);
}
Console.WriteLine((a % 100) / 10);