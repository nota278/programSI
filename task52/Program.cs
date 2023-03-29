// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double [] SumColumns (int [,] arr)
{
    double [] sumcol = new double [arr.GetLength (1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum =0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr [i,j];
        }
        sum = sum / arr.GetLength (0);
        sumcol [j] = Math.Round(sum, 1);
    }
    return sumcol;

}
void PrintArray1 (double [] arr)
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length - 1) Console.Write ($"{arr [i]}  ");         
        else Console.Write ($"{arr [i]}");
              
               
    }
    Console.Write("]");

}
Console.WriteLine ("Введите количество строк str ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов stol ");
int stol = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArrayRndInt (str, stol, -10, 10);
PrintArray (array);
Console.WriteLine ();
double [] sucol = SumColumns (array);
Console.WriteLine ("Среднее арифметическое каждого столбца: ");
PrintArray1 (sucol);