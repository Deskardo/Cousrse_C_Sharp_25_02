// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a = int.Parse(Console.ReadLine()!);

if(a < 100)
{
  Console.WriteLine("Третей цифры нет");
}

Console.WriteLine(a);
Console.WriteLine((a / 100 * 10) + (a % 10));