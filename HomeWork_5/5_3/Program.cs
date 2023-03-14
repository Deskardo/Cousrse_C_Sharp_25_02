// Задайте массив, вещественных чисел.
// Найдите разницу между максимальным и минимальым значением элементов массива

void Print(double[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

double[] MassNums(int size, double from, double to)
{
  double[] arr = new double[size];

  for (int i = 0; i < size; i++)
  {
    arr[i] = to + new Random().NextDouble() * (from - to);
  }
  return arr;
}

void MinMaxDiff(double[] arr)
{
  double min = arr[0];
  double max = arr[0];
  double diff = 0;

  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > max)
      max = arr[i];
    else if(arr[i] < min)
      min = arr[i];
      diff = max - min;
  }
  Console.WriteLine($"Минимальное значение {min}");
  Console.WriteLine($"Максимальное значение {max}");
  Console.WriteLine($"Разница между максимальным и минимальным значением равна {diff}");
}




Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона");
double start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона");
double stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
MinMaxDiff(mass);

