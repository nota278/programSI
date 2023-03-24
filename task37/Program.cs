// Зад. 37. Найти произведение пар чисел
// в одномерном массиве. Парой считаются
// первый и последний, второй и предпоследний
// и т.д. элементы. Результат записать в новом массиве
// [1 2 3 4 5] -> 5 8 3
// [6 7 8 3] -> 18 56

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

int []  ProductOfPairs (int [] arr)
{
    int size=arr.Length %2 > 0 ? arr.Length/2 + 1 : arr.Length/2;
    int [] newArray = new int [size];

    for (int i = 0; i < arr.Length /2; i++)
    {
        int number= arr [i] * arr [arr.Length-1-i];     
        newArray [i] = number;
    }

    if (arr.Length % 2 > 0)
    {
        int indexMed = arr.Length/2;
        newArray [size - 1] = arr [indexMed];
    }
    return newArray;
}

int [] array = CreateArrayRndInt (11, 1, 10);
PrintArray (array);
Console.WriteLine ();
int [] arr2 = ProductOfPairs (array);
PrintArray (arr2);