// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int a = int.Parse(Console.ReadLine()!);
int N = -a;

while (N <= a)
{
  Console.Write(N + ", ");
  N++;
}
