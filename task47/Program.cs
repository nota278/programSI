// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double [,] CreateArrayRndDouble (int rows, int columns, int min, int max)
{
    double [,] matrix = new double [rows, columns];
    Random rnd = new Random ();
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
            double num = rnd.NextDouble () * (max-min) + min;
            matrix [i, j] = Math.Round(num, 1);
       }
       
        
    }
    return matrix;
}

void PrintArray (double [,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            
            Console.Write ($"{matrix [i, j],  5}  ");         
           

        }
                     
    Console.WriteLine ();           
    }
    
}


Console.WriteLine ("Введите количество строк str ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов stol ");
int stol = Convert.ToInt32(Console.ReadLine());

double [,] array = CreateArrayRndDouble (str, stol, -50, 50);
PrintArray (array);
Console.WriteLine ();