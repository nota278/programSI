// Задача 46. Создать двумерный массив, размером
// m*n, заполненный случайными целыми числами.
// Допустим 3*4:
// -2 3 56 -8
// 34 -7 6 -5
// 17 -4 3 23
// 25 -3 -8 7

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
            
            Console.Write ($"{matrix [i, j],  3}  ");         
           

        }
                     
    Console.WriteLine ();           
    }
    
}
Console.WriteLine ("Введите количество строк str ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов stol ");
int stol = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArrayRndInt (str, stol, -100, 100);
PrintArray (array);
Console.WriteLine ();