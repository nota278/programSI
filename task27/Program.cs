﻿// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число ");
int chi = Convert.ToInt32(Console.ReadLine());
int result = Sumzi (chi);
Console.WriteLine($"Сумма цифр числа  {chi} = {result} ");
int Sumzi (int num)
{
    int sum = 0;
    
    while (num > 0)
    {           
        sum = sum + num % 10;
         num  /= 10;
    }

    return sum;
}