// Задача59. Создать двумерный массив целых чисел.
// Написать программу, которая удалит строку и столбец,
// на пересечении которых находится наименьший элемент
// массива. 




Console.WriteLine ("Введите количество строк line ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArrayRndInt (line, column, 0, 10);
Console.WriteLine(" Исходный массив" );
PrintMatrix (array);
int [] coords = CoordinateMinElementArray (array);

Console.WriteLine ("Модифицированный массив");
PrintModifiedMatrix (array, coords);
int [] CoordinateMinElementArray (int [,] arr)
{
    int minRows=0;
    int minColums=0; 
    
    for (int i = 0; i < arr.GetLength (0); i++)
    {
        for (int j = 0; j < arr.GetLength (1); j++)
        {
            if (arr [minRows, minColums] >= arr [i, j]) 
            {
                
                minRows = i;
                minColums = j;
            }   
        }
       
    }
    return new int []{minRows, minColums};  

}

void PrintModifiedMatrix (int [,] matrix, int []coor)
{
    int lin = coor [0];
    int col = coor [1];
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            if (i==lin || j==col) continue;
            else Console.Write ($"{matrix [i, j],  3}");
        }
        Console.WriteLine ();
    }




}



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
