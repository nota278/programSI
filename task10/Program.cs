// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите целое положительное 3-х значное число ");
int hi=Convert.ToInt32(Console.ReadLine());
int result = Twochi(hi);
Console.WriteLine($"Вторая цифра числа {hi} = {result}");
int Twochi(int num)
{
    int zifra1 = num/10;
    int zifra2 = zifra1%10;
    return zifra2;
    
}