// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string Convert(int num)
{
  string result = "";
  while (num > 0)
  {
    result = num % 2 + result;
    num = num / 2;
  }
  return result;
}

Console.WriteLine("Введите число для конвертации:");
int a = int.Parse(Console.ReadLine()!);
string res = Convert(a);
Console.WriteLine(res);