// Напишите программу, которая принимает два числа A и B и возводит число
// A в целую степень B с помощью рекурсии.

Console.Clear();

int ValueDeegree(int A, int B)
{
  if (B == 0) return 1;
  return ValueDeegree(A, B - 1) * A;
}

int num = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(ValueDeegree(num, num2));