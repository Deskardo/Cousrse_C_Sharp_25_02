// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int a = int.Parse(Console.ReadLine()!);
int N = 2;

while (N <= a)
{
  if (N % 2 == 0)
  { 
    Console.Write(N + ", "); 
    N++;
  }
  else
  {
    N++;
  }
}
