// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов


void Print(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      Console.Write($" {arr[i, j]} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
  int[,] arr = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = new Random().Next(from, to);

  return arr;
}

void MinimalSumRow(int[,] baseArr)
{
  int rowNum = 0;
  int min = 0;

  for (int i = 0; i < baseArr.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < baseArr.GetLength(1); j++)
    {
      sum += baseArr[i, j];
    }
    if (i == 0)
    {
      min = sum;
    }
    else
    {
      sum = min;
      rowNum = i;
    }
  }
  Console.WriteLine($"Минимальная сумма элементов находится в строке {rowNum + 1} и равна {min}");
}


Console.WriteLine("Введите количество строк массива");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число в массиве");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максмальное число в массиве");
int stop = int.Parse(Console.ReadLine()!);



int[,] mass = MassNums(num_row, num_column, start, stop);
Console.WriteLine("Изначальный массив");
Print(mass);
MinimalSumRow(mass);