﻿// Напишите программу замена элементов массива: положительные элементы амените на соответствующие отрицательные, и наоборот.


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

void ArrNeg(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = -arr[i];
    Console.Write($"{arr[i]} ");
  }
}



int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
ArrNeg(mass);