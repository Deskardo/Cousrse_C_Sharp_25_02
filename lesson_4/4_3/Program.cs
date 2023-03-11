// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами, в случайном порядке.

void Massiv(int lenght)
{
  int[] arr = new int [lenght];
  for(int i = 0; i < lenght; i++)
  {
    arr[i] = new Random().Next(2);
    Console.Write(arr[i]);
  }
}

Massiv(int.Parse(Console.ReadLine()!));