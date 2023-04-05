// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine ("Введите количество строк line1 первой матрицы");
int line1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column1 первой матрицы ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество строк line2 второй матрицы");
int line2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column2 второй матрицы ");
int column2 = Convert.ToInt32(Console.ReadLine());
if (column1 != line2) Console.WriteLine ("умножение таких матриц не возможно");
int [,] array1 = CreateArrayRndInt (line1, column1, 1, 10);
Console.WriteLine(" Первая матрица" );
PrintMatrix (array1);
int [,] array2 = CreateArrayRndInt (line2, column2, 1, 10);
Console.WriteLine(" Вторая матрица" );
PrintMatrix (array2);
int [,] multiplikator = Matrixmultiplication (array1, array2);
Console.WriteLine("Матрица произведений" );
PrintMatrix (multiplikator);

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
int [,] Matrixmultiplication (int [,] matrix1, int [,] matrix2)
{
    int [,] matrix = new int [matrix1.GetLength(0), matrix2.GetLength (1)];
    for (int i = 0; i < matrix1.GetLength (0); i++)
    {
        for (int j = 0; j < matrix2.GetLength (1); j++)
        {
            matrix [i, j] = 0;
            for (int k = 0; k < matrix1.GetLength (1); k++)
            {
                matrix [i, j] += matrix1 [i, k] * matrix2 [k,j];
            }
            
        }   
    }
    return matrix;

}