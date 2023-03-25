// Задайте значения M и N.
// Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.

Console.Clear();

void ValuesSet(int M, int N)
{
  if (M > N) return;
  ValuesSet(M, N - 1);
  Console.Write($"{N} ");
}

int num = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num, num2);