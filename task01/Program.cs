﻿// На вход подаются два числа
// Программа проверяет, является ли первое
//  число квадратом второго
//  а=25, b=5 -> да
//  a=2,  b=10 -> нет
//  a=9,  b=-3 -> да

Console.WriteLine("Введите первое число");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b =Convert.ToInt32(Console.ReadLine());
if (a==b*b)
{
  Console.WriteLine($"Первое число {a} является квадратом второго {b} ->да");  
}
else
{ 
     Console.WriteLine($"Первое число {a} не является квадратом второго {b} -> нет");
}