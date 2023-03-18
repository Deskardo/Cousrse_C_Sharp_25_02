// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Укажите день недели");
int a = int.Parse(Console.ReadLine()!);

while (a < 1 || a > 7)
{
  Console.WriteLine("Указанное число не является днём недели");
  a = int.Parse(Console.ReadLine()!);
}
if (a == 6 || a == 7)
{
  Console.WriteLine("ДА, это выходной");
}
else
{
  Console.WriteLine("Нет, не время отдыхать, пора за работу");
}