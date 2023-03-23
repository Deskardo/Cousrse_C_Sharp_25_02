// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на 
// пересечении которых расположен наименьший элемент массива.

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

int[,] FindMinimumNumber(int[,] mainArr, int[,] positionArr)
{
  int min = mainArr[0, 0];

  for (int i = 0; i < mainArr.GetLength(0); i++)
    for (int j = 0; j < mainArr.GetLength(1); j++)
    {
      if (min > mainArr[i, j])
      {
        positionArr[0, 0] = i;
        positionArr[0, 1] = j;
        min = mainArr[i, j];
      }
    }
  Console.WriteLine($"Минимальное значение в массиве = {min} ");
  Console.WriteLine($"расположено в строке {positionArr[0, 0]} колонке {positionArr[0, 1]}");
  return positionArr;
}

int[,] CrossPositionDelete(int[,] mainArr, int[,] positionArr)
{
  int k = 0;
  int l = 0;
  int[,] NewArr = new int[mainArr.GetLength(0) - 1, mainArr.GetLength(1) - 1];

  for (int i = 0; i < mainArr.GetLength(0); i++)
  {
    for (int j = 0; j < mainArr.GetLength(1); j++)
    {
      if (positionArr[0,0] != i && positionArr[0,1] != j)
        {
          NewArr[k, l] = mainArr[i, j];
          l++;
        }
      }
    l=0;
    if(positionArr[0,0] != i)
    {
      k++;
    }
  }
  return NewArr;
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
int[,] pos = new int[1, 2];
int[,] massCrossDel = CrossPositionDelete(mass, FindMinimumNumber(mass, pos));
Console.WriteLine("Новый массив:");
Console.WriteLine();
Print(massCrossDel);
