// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int SumNum(int num)
{
  int kol = 1;
  for (int i = 1; i <= num; i++)
  {
    kol = kol * i;
  }
  return kol;
}

int N = int.Parse(Console.ReadLine()!);
int result = SumNum(N);
Console.WriteLine(result);