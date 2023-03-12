// 1. На вход подаются два числа
// 2. Является ли первое число
// кратным второму. Если первое не кратно второму,
// то выводится остаток от деления
//  34, 5   не кратно, остаток 4
//  16, 4   кратно
Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
int result = Multipli(a,b);
if (result==0 )
    Console.WriteLine("Число кратно");
else
    Console.WriteLine($"Остаток от деления  {result}");
int Multipli(int num1, int num2)
{
    int zifra1 = num1%num2;
    
    return zifra1;
}    
