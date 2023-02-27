// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число наибольшее, а какое наименьшее

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
  Console.WriteLine(a + "max" + " " + b + "min");
}
else 
{
  Console.WriteLine(b + "max" + " " + a + "min");
}