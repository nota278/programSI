// 1. Ввети число
// 2. Вывести все четные числа, включая само число
// 
Console.WriteLine("Введите целое положительное число ");
int hi=Convert.ToInt32(Console.ReadLine());
int count=-hi;
Console.WriteLine("Четные числа, входящие в диапазон -hi до hi: ");
while (count<=hi)
{
   if (count%2==0)
   {
        Console.Write($"   {count}"); 
   }
   count++;
}

