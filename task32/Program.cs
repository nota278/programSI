// Задача 32: Написать программу замены элементов 
// массива: положительные элементы заменить
// на соответствующие им отрицательные и наоборот
// [-4, -8, 2, 4] -> [4, 8, -2, -4]


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
void InversArray (int [] arr)
{
    for (int i = 0; i <arr.Length; i++)
    {
        arr [i] *= -1;
    }


}
int [] mas = CreateArrayRndInt (4, -9, 9);
PrintArray (mas);
Console.WriteLine ();
InversArray (mas);
PrintArray (mas);