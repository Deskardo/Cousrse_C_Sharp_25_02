// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.


void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}


int[] MassNums(int size)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
  {
    Console.WriteLine("Введите следующее число");
    arr[i] = int.Parse(Console.ReadLine()!);
  }
  Console.WriteLine("Спасибо, ввод данных завершен");
  Console.WriteLine("Вы указали числа:");
  return arr;
}

void CountPositiveNumbers(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
      count++;
  }
  Console.WriteLine($"Из них, Вы ввели {count} чисел(ла) больше нуля!");
}

Console.WriteLine("Сколько чисел Вы бы хотели ввести?");
int num = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num);
Print(mass);
CountPositiveNumbers(mass);