// Зад. 22: на вход подается число N
// На выходе - таблица квадратов 
// чисел от 1 до N

Console.WriteLine("Введите натуральное число");
int chi=Convert.ToInt32(Console.ReadLine());
TablSqrt (chi);

void TablSqrt (int num)
{  
    int count=1;
    while (count <= num)
    {
       int sq = count*count;
       Console.WriteLine($"{count, 3} ->  {sq}");
        count++;
    }
}
