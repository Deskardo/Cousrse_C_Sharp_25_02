// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X и Y)

void Coordinats(int num)
{
  if (num < 1 || num > 4)
      Console.WriteLine("Error");
  else if (num == 1)
    Console.WriteLine("x > 0, y > 0");
  else if (num == 2)
    Console.WriteLine("x < 0, y > 0"); 
  else if (num == 3)
    Console.WriteLine("x < 0, y < 0");  
  else if (num == 4)
    Console.WriteLine("x > 0, y < 0");
}

int num_1 = int.Parse(Console.ReadLine()!);
Coordinats(num_1);