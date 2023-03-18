// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

int[] Fibo(int num)
{
  int[] arr = new int[num];
  arr[0] = 0;
  arr[1] = 1;
  for (int i = 2; i < num; i++)
  {
    arr[i] = arr[i - 1] + arr[i - 2];
  }
  return arr;
}

int N = int.Parse(Console.ReadLine()!);
int[] mass = Fibo(N);
Print(mass);