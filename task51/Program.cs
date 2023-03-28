// Зад.51 В двумерном массиве найти сумму элементов
// главной диагонали,т.е. с индексами [0, 0]
// [1, 1] и т.д.



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

int  SumElementsOfMainDiagonal (int [,] matrix)

{
    int sum=0;
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            
            if(i==j) sum += matrix [i, j];         
           

        }

    }
    return sum;
}
Console.WriteLine ("Введите количество строк str ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов stol ");
int stol = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArrayRndInt (str, stol, -10, 10);
PrintArray (array);
Console.WriteLine ();
int mainsum = SumElementsOfMainDiagonal (array);
Console.WriteLine ($"Сумма элементов главной диагонали = {mainsum}");