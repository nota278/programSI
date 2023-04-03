
// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine ("Введите количество строк line ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArrayRndInt (line, column, 1, 20);
Console.WriteLine(" Исходный массив" );
PrintMatrix (array);
int [] sumLine = SumLineMatrix (array);
int indminsum = IndexMinSum (sumLine);
Console.WriteLine ($"Строка с минимальной суммой элементов в ней  {indminsum} ");
int [,] CreateArrayRndInt (int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random ();
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
            matrix [i, j] = rnd.Next (min, max+1);
       }
               
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            
            Console.Write ($"{matrix [i, j],  3}  ");     
           
        }
                     
    Console.WriteLine ();           
    }
    
}
int [] SumLineMatrix (int [,] matrix)
{
    int [] sumline= new int [matrix.GetLength (0)];
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            for (int k = 0; k < matrix.GetLength (1); k++)
            {
                sum += matrix [i, k];
                
            }
        }
        sumline [i] = sum;
        sum = 0;
    }
    return sumline;

}

int IndexMinSum (int [] arr)
{
    int ind = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min >=arr [i])
        {
            min= arr [i];
            ind = i;
        } 
    }
    return ind;

}