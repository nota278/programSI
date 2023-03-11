// 1. Вводим целое натуральное число
// 2. Получить ряд чисел от -n до n
// 

Console.WriteLine("Введите целое положительное число число");
int a=Convert.ToInt32(Console.ReadLine());
int count = -a;
while (count <= a)
{
    Console.Write($"   {count}");
    count++;
}
