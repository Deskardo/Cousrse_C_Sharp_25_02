// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


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

void Find(int f_num, int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == f_num)
    {
      Console.WriteLine($"Искомое число {arr[i]} содержится в массиве");
      return;
    }
  }
  Console.WriteLine($"Искомое число {f_num} не содержится в массиве");
}


Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона");
int stop = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine("Введите искомое число");
int find_num = int.Parse(Console.ReadLine()!);
Find(find_num, mass);