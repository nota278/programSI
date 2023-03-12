// Задача 11: Напишите программу, которая принимает на вход трёхзначное 
// число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
Console.WriteLine("Введите целое положительное 3-х значное число ");
int hi=Convert.ToInt32(Console.ReadLine());
int result = Twochi(hi);
Console.WriteLine($"Из  {hi}  получили  {result}");
int Twochi(int num)
{
    int zifra1 = num/100;
    int zifra3 = num%10;
    int zifra2 = zifra1%10;
    return (zifra1*10+zifra3);
    
}