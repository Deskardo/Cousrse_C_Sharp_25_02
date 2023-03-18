// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

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

int DiagonalSumm(int[,] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i == j)
        sum = sum + arr[i, j];
    }
  }
  return sum;
}



int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int sum = DiagonalSumm(mass);
Console.WriteLine($"Сумма {sum}");
