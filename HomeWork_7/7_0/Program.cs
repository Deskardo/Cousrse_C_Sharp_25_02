// Задайте двумерный массив размером m на n
// заполненный случайными вещественными числами.


void Print(double[,] arr)
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

double[,] MassNums(int row, int column, double from, double to, int pointNum)
{
  double[,] arr = new double[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      arr[i, j] = Math.Round(to + new Random().NextDouble() * (from - to), pointNum);

  return arr;
}



Console.WriteLine("Введите количество строк массива");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество колонок массива");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число в массиве");
double start = double.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максмальное число в массиве");
double stop = double.Parse(Console.ReadLine()!);
Console.WriteLine("Сколько цифр оставить после запятой");
int point = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop, point);
Print(mass);