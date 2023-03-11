// Напишите программу, которая задаёт массив из 8 элементов случайными числами
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)

void Array(int lenght)
{
  int[] arr = new int [lenght];
  for(int i = 0; i < lenght; i++)
  {
    arr[i] = new Random().Next(0, 100);
    Console.Write(arr[i]);
    Console.Write(", ");
  }
}

Array(int.Parse(Console.ReadLine()!));