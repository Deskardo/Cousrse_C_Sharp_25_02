// Задайте значения M и N. Напишите программу, которая выведет
// все четные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Clear();

void EvenSum(int M, int N)
{
  if (M > N) return;
  if (N % 2 == 1) N--;
  EvenSum(M, N - 2);
  Console.Write($"{N} ");
}

int num = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
EvenSum(num, num2);