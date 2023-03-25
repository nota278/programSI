// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным 
//  элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] CreateArrayRndDouble (int size, int min, int max)
{
    double [] arr = new double [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble () * (max-min) + min;
        arr [i] = Math.Round(num, 1);
        
    }
    return arr;
}

void PrintArray (double [] arr)
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length - 1) Console.Write ($"{arr [i]}  ");         
        else Console.Write ($"{arr [i]}");
              
               
    }
    Console.Write("]");
}
double MaxElement (double [] arr)
{
    double max = arr [0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max <= arr[i]) max = arr[i];
                 
    }
    return max;

}

double MinElement (double [] arr)
{
    double min = arr [0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min >= arr[i]) min = arr[i];
                 
    }
    return min;

}
double [] array = CreateArrayRndDouble (12, 1, 90);
PrintArray (array);
Console.WriteLine();
double ym = MaxElement (array);
Console.WriteLine($"Максимальный элемент = {ym}");
double xm = MinElement (array);
Console.WriteLine($"Минимальный элемент = {xm}");
double res=Math.Round(ym-xm, 1);
Console.WriteLine($" max-min  =  {res}");