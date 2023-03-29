// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool SearchItemByIndex (int [,] matrix, int str, int col)
{
       
        
    
    if (str< matrix.GetLength(0) && str >=0 && col<matrix.GetLength(1) &&
        col>=0)  return true;   
    else return false;               
                    
             
    
}






Console.WriteLine ("Введите количество строк str ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов stol ");
int stol = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArrayRndInt (str, stol, -10, 10);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine ("Введите номер строки str1 ");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите номер столбца stol2 ");
int stol2 = Convert.ToInt32(Console.ReadLine());
int result = SearchItemByIndex (array, str1, stol2) == true 
? array[str1-1, stol2-1] : 1;
if (result==1) Console.WriteLine ("Такого числа нет");

Console.Write ($"  {result}");
