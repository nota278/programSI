// 1. Вывести случайное число из диапазона
// [10,99]
// 2. Вывести наибольшую цифру числа
// 
int number = new Random().Next(10,100);
Console.WriteLine($"Случайная цифра числа из диапазона от10 до 99 {number}");
int result = Maxchi(number);
Console.WriteLine($"Большая цифра числа {number} = {result}");
int Maxchi(int num)
{
     int zifra1 = num/10;
     int zifra2 = num%10;
     int maxchi = zifra1 > zifra2 ? zifra1:zifra2;
     return maxchi;
}
