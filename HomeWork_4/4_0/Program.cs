// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

int Degree(int num1, int num2)
{
  int deg = num1;
  for(int i = 1; i < num2; i++)
  {
    deg = deg*num1;
  }
  return deg;
}

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Degree(A, B));