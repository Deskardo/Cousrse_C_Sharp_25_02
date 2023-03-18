// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string a = Console.ReadLine()!;
int b = int.Parse(a)!;

if (b < 100)

{
  Console.WriteLine("Третей цифры нет");
}

else
{
  Console.WriteLine(a[2]);
}
