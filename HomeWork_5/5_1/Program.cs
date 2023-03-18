// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

void CountEven(int[] arr)
{
  int count = 0;
  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i]%2==0)
    count++;
  }
  Console.WriteLine($"В заданном массиве {count} четных чисел");
}




Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
CountEven(mass);

