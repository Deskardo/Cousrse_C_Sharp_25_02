// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(from, to);
  }
  return arr;
}

int[] CompMass(int[] arr)
{
  int size = 0;

  if (arr.Length % 2 == 1) 
    size = arr.Length / 2 + 1;
  else size = arr.Length / 2;

  int[] arr2 = new int[size];

  for (int i = 0; i < size; i++)
  {
    if (arr.Length % 2 == 1 && i == size - 1)
      arr2[i] = arr[i];
    else arr2[i] = arr[i] * arr[arr.Length - 1 - i];
  }
  return arr2;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int[] mass2 = CompMass(mass); // в качестве аргумента первый массив
Print(mass2);                 // в качестве аргумента массив из тертьего метода

