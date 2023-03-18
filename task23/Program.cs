// Напишите программу, которая принимает
//  на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите натуральное число");
int chi=Convert.ToInt32(Console.ReadLine());
TablSkub (chi);

void TablSkub (int num)
{  
    int count=1;
    while (count <= num)
    {
       int sq = count*count*count;
       Console.WriteLine($"{count, 3} ->  {sq}");
        count++;
    }
}








