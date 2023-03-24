// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// Элементы каждой строки двумерного массива.

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

int[,] SortedMass(int[,] baseArr)
{
    for (int i = 0; i < baseArr.GetLength(0); i++)
  {
    for (int j = 0; j < baseArr.GetLength(1); j++)
    {
      for (int k = 0; k < baseArr.GetLength(1) - 1; k++)
      {
        if (baseArr[i,k] < baseArr[i, k +1])
        {
          int sort = baseArr[i,k +1];
          baseArr[i,k +1] = baseArr[i,k];
          baseArr[i,k] = sort;
        }
      }
    }
  }
  return baseArr;

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
Console.WriteLine("Отсортированный массив");
Print(SortedMass(mass));