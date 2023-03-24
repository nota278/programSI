// Зад. 35: Создать одномерный массив из 123 элементов.
// Найти сколько элементов находится в диапазоне
// от [10, 99]. Например, для 5 элементов:
// [15, 123, 8, 3, 102] -> 1
// [2, 8, 102, 3, 200] -> 0
// [17, 36, 10, 99, 25] -> 5

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
        if (i< arr.Length - 1) Console.Write ($"{arr [i]}    ");         
        else Console.Write ($"{arr [i]}");
              
               
    }
    Console.Write("]");
}

int NumOfRangeNum (int [] arr)
{
    int range = 0;    
    for (int i = 0; i < arr.Length -1; i++)
    {
        if (arr[i] >=10 && arr[i] <=99 ) range+= 1;

    }
    return range;

}

int [] array = CreateArrayRndInt (123, 1, 200);
PrintArray (array);
Console.WriteLine ();
int numofra= NumOfRangeNum (array);
Console.WriteLine ($"Количество элементов от 10 до 99= {numofra}");
