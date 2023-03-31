// Зад.55 Создать двумерный массив. 
// Поменять в нем строки со столбцами.
// В случае, если это невозможно, программа
// должна выдавать сообщение пользователю.
// (Это возможно, если матрица квадратная)

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
bool Check (int [,] matrix)
{
    
    {
               
        return (matrix.GetLength (0) == matrix.GetLength (1));
    }


}
void RowSwapWithColumns (int [,] matrix)

{
    if (matrix.GetLength (0) != matrix.GetLength (1))
    {
        Console.WriteLine ("Число строк должно быть равно числу столбцов");        
        return;
    }
    
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
           
        for (int j = 0; j < i; j++)
        {            
            int temp = matrix [i,j];
              
            matrix [i,j] = matrix [j, i];
            matrix [j,i] = temp;                           
        
        }
    }

}


Console.WriteLine ("Введите количество строк line ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArrayRndInt (line, column, -10, 10);
PrintArray (array);
Console.WriteLine (); 
if (Check (array))
{
    RowSwapWithColumns (array);  
    PrintArray (array); 
}
else
{
 Console.WriteLine ("Ошибка. Количество строк и столбцов должны быть равны");
}

