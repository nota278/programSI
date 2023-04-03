// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine ("Введите количество строк line ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArrayRndInt (line, column, 1, 20);
Console.WriteLine(" Исходный массив" );
PrintMatrix (array);
SortLineMatrix (array);
Console.WriteLine(" Сортировка в строке" );
PrintMatrix (array);

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

int [,] SortLineMatrix (int [,] matrix)
{

    for (int i = 0; i < matrix.GetLength (0) ; i++)
    {
        // int maxline= matrix [i,0];
        // int t = matrix [i,0];
        for (int j = 0; j < matrix.GetLength (1); j++)        
        {   
            for (int k = 0; k < matrix.GetLength (1) -1; k++)
            {
                if (matrix [i, k] <= matrix [i, k+1])

                {
                    int t = matrix [i, k];
                    matrix [i, k] = matrix [i, k+1];
                    matrix [i, k+1] = t;
                } 
            }
                               
        }

    }
    return matrix;
}