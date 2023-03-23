// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

void FirstWithLast(int [,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for(int j = 0; j < column; j++)
    (arr[0, j], arr[row -1, j]) = (arr[row -1, j], arr[0, j]);
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
Print(mass);
FirstWithLast(mass);
Print(mass);