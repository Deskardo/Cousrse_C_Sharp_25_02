// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

void FindPosition(int[,] viewedArr, int x, int y)
{
    if (x < 0 || y < 0 || x > viewedArr.GetLength(0) || y > viewedArr.GetLength(1))
    Console.WriteLine("Такого числа нет в массиве");
    else Console.WriteLine($"на позиции [{x}, {y}] расположено значение {viewedArr[x, y]}");
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

Console.WriteLine("Введите искомый номер строки");
int rowNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите искомый номер колонки");
int columnNum = int.Parse(Console.ReadLine()!);

FindPosition(mass, rowNum, columnNum);