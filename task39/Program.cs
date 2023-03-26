// Задача 39: Написать программу, которая
// перевернет одномерный массив (последний
// элемент будет на первом месте, первый на
// последнем): [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 2] -> [2 3 7 6]

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

void ReversArray (int [] arr)
{
   
    for (int i = 0; i < arr.Length/2; i++)
    {
        int number= arr [i];     
        arr [i] = arr [arr.Length-1-i];
        arr [arr.Length-1-i] = number;
    
    }

}

int [] array = CreateArrayRndInt (10, 1, 10);
PrintArray (array);
Console.WriteLine ();
ReversArray (array);
PrintArray (array);