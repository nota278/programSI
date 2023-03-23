// Зад. 33: Задать массив и определить
// присутствует ли заданное число в этом массиве
// 4; массив [6, 7, 345, 19, 3] -> нет
// 8; массив [4, -7, 8, 56, 3] ->  да
int [] mas = CreateArrayRndInt (8, -9, 10);
PrintArray (mas);
Console.WriteLine ();
Console.WriteLine ("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string result = SearchNum (mas, number) == true ? " - >  Да" : " - >  Нет";
Console.Write ($"Число {number}   {result}");

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
 bool SearchNum (int [] arr, int num)
 {
    for (int i = 0; i <arr.Length; i++)
    {
        if (arr [i] == num) return true;
    }

    return false;
 }