﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

void Explorer(int num1, int num2)
{
  if (num1 % num2 == 0)
  {
    Console.WriteLine("Кратно");
  }
  else
  {
    Console.WriteLine($"не кратно {num1 % num2}");
  }
}

Explorer(16, 4);