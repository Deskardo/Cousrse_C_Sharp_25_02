// Задайте двумерный массив размером m x n,
// каждый элемент в массиве находится по формуле:A[][] = m+n
// Выведите полученный массив на экран.

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

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = i + j;

    return arr;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column);
Print(mass);