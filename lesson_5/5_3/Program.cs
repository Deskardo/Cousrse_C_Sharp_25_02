// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отезке [10,99]


void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}


int[] MassNums(int size, int from, int to)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(from, to);
  }
  return arr;
}

void Count(int num1, int num2, int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] >= num1 && arr[i] <= num2)
    {
      count++;
    }
  }
  Console.WriteLine($"В заданном диапазоне {count} значения(й)");
}


Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона");
int stop = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine("Введите нижнюю границу поиска");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу поиска");
int num_2 = int.Parse(Console.ReadLine()!);
Count(num_1, num_2, mass);

