// Зад.48. Задать двумерный массив m*n,
// каждый элемент которого формируется 
// по формуле А [m, n] = m+n. Вывести
// на экран.


int [,] CreateArrayRndInt (int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    // Random rnd = new Random ();
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
            matrix [i, j] = i+j;
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
            
            Console.Write ($"{matrix [i, j],  3}  ");         
           

        }
                     
    Console.WriteLine ();           
    }
    
}
Console.WriteLine ("Введите количество строк str ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов stol ");
int stol = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArrayRndInt (str, stol, -10, 10);
PrintArray (array);
Console.WriteLine ();
