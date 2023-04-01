// Зад.57 Составить частотный словарь элементов
// двумерного массива. Он включает сколько раз
// в массиве встречается элемент
// входных данных.

// Набор данных	Частотный массив
//   1 2 3 	   1 встречается 3 раза
//   4 6 1	       2 встречается 2 раза
//   2 1 6	       3 встречается 1 раз
// 	           4 встречается 1 раз
// 	           6 встречается 6 раз


Console.WriteLine ("Введите количество строк line ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов column ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArrayRndInt (line, column, 0, 10);
Console.WriteLine("   Набор данных" );
PrintMatrix (array);
Console.WriteLine (); 
int [] arrayel = MatrixToArray (array);
Array.Sort (arrayel);
Console.WriteLine ("Частотный массив");     
OutputTheQuantitOfEachElement (arrayel);

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
int [] MatrixToArray ( int [,] matrix)
{
    int [] arr = new int [matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           arr [k] = matrix [i, j];
           k++;
        }
    }
    return arr;

}
void OutputTheQuantitOfEachElement (int [] arr)
{
    int count = 1;
    int current = arr [0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr [i] == current) count +=1;
        else
        {
            Console.WriteLine ($"{current}  встречается  {count} раз");
            count = 1;
            current = arr [i];
        }
    }


}