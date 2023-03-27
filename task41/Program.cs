// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.WriteLine ("Cколько чисел будите вводить?");
int num = Convert.ToInt32(Console.ReadLine());
int [] chi = CreateArrayRndInt (num);
int zero = NumberOfZero (chi);
PrintArray (chi);
Console.WriteLine ($" - > {zero}");

int [] CreateArrayRndInt (int size)
{
    int [] arr = new int [size];
    Console.WriteLine ($"Введите  {size}  чисел");
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = Convert.ToInt32(Console.ReadLine());

        
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

int NumberOfZero (int [] arr)

{
    int sum=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum+=1;
    }

    return sum;

}