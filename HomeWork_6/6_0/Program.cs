// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

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

double[] CopyArray(int size2, double[] firstArray)
{
  double[] finalArray = new double[size2];
  for (int i = 0; i < size2; i++)
  {
    finalArray[i] = firstArray[i];
  }
  return finalArray;
}


Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона");
double start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона");
double stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
double[] copyMass = CopyArray(num, mass);
Print(copyMass); 
