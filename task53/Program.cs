// Задача 53. Задайте двумерный массив. Написать 
// программу, которая поменяет местами первую и
// последнюю строки массива.

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

void PrintArray (int [,] matrix)
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

void ReplacString (int [,] matrix)

{
    
    int lastRow = matrix.GetLength (0)-1; 
    
        for (int j = 0; j < matrix.GetLength (1); j++)
        {            
           int temp = matrix [0,j];
              
            matrix [0,j] = matrix [lastRow, j];
            matrix [lastRow, j] = temp;
                                  
        
        }

}
    
Console.WriteLine ("Введите количество строк line ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArrayRndInt (line, column, -10, 10);
PrintArray (array);
Console.WriteLine (); 
Console.WriteLine ("Поменялись первая и последняя строки");
ReplacString (array);  
PrintArray (array);   
    



