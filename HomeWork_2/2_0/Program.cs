// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int a = int.Parse(Console.ReadLine()!);

while (a < 100 || a > 999)
{
  Console.WriteLine("Число не является трехзначным, введите корректное число");
  a = int.Parse(Console.ReadLine()!);
}
Console.WriteLine((a % 100) / 10);