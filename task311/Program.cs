﻿// Задача 31:
// 1. Задайте массив из 12 элементов,
// 2. заполненный случайными числами из промежутка [-9, 9]
// 3. Найти сумму положительных и отрицательных элементов массива

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int [] CreateArrayRndInt (int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = rnd.Next (min, max+1);
        
    }
    return arr;
}

void PrintArray (int [] arr)
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length - 1) Console.Write ($"{arr [i]}  ");         
        else Console.Write ($"{arr [i]}");
              
               
    }
    Console.Write("]");
}

int SumPositiveElements (int [] arr)
{
    int sum=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] >= 0) sum+= arr [i];

    }
    return sum;

}
int SumNegativeElements (int [] arr)
{
    int sum=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] < 0) sum+= arr [i];

    }
    return sum;

}

int [] array = CreateArrayRndInt (12, -9, 9);
PrintArray (array);
Console.WriteLine ();
int pos=SumPositiveElements (array);
Console.WriteLine ($"Сумма положительных элементов = {pos}");
int neg = SumNegativeElements (array);
Console.WriteLine ($"Сумма отрицательных элементов = {neg}");
