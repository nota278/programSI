// Зад.49 Задать двумерный массив. Заменить
// в нем элементы, у которых оба индекса 
// четные, на их квадраты.
// Пример:
// 1 2 3 4  на:   1 2 9 4

// 5 6 7 8        5 6 7 8
// 3 2 2 5        9 2 4 5


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

int [,] EvenIndicesPerSquare (int [,] matrix)

{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            
            if(i%2 ==0 && j%2==0) matrix [i, j] =  matrix [i, j] *matrix [i, j];         
           

        }

    }
    return matrix;
}
Console.WriteLine ("Введите количество строк str ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов stol ");
int stol = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArrayRndInt (str, stol, -10, 10);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine ("Измененный массив");
int [,] array2 = EvenIndicesPerSquare (array);
PrintArray (array2);