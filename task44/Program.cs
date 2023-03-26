// Зад 44. Не используя рекурсию, вывести
// первые N чисел Фибоначчи. Первые два
// числа: 0 1.
// Если N=5, то выведется 0 1 1 2 3
// При N=3, 0 1 1
// При N=7, 0 1 1 2 3 5 8 


Console.WriteLine ("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int [] fiboarr=FiboArray (num);
PrintArray (fiboarr);

int [] FiboArray(int number)
{
    int[] array = new int[number];
    array [0] = 0;
    array [1] = 1;
    for (int i = 2; i < number; i++)

    {
        array [i] = array [i-1] + array [i-2];
        
    }
    return array;

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