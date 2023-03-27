// Задача 45. Написсать программу, которая
// будет создавать копию заданного массива
// поэлементным копированием

int [] array = CreateArrayRndInt (10, 1, 10);
PrintArray (array);
Console.WriteLine ();
int [] copyarr = ArrayCopy (array);
Console.WriteLine ("Копия заданного массива");
PrintArray (copyarr);


int [] CreateArrayRndInt (int size, int min, int max)
{
    int [] arr = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = rnd.Next (min, max+1);
        
    }
    return arr;
}

void PrintArray (int [] arr)
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length - 1) Console.Write ($"{arr [i]}  ");         
        else Console.Write ($"{arr [i]}");
              
               
    }
    Console.Write("]");
}

int [] ArrayCopy (int [] arr)

{
    int [] arrcop = new int [arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        arrcop [i] = arr [i];
        
    }
    return arrcop;

}