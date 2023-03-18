// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру

int a = new Random().Next(100, 1000);

Console.WriteLine(a);
Console.WriteLine((a / 100 * 10) + (a % 10));
