// 1.На вход подаются два числа
// 2.Вывести максимальное из них

Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Большее число   {a}");
}
else if (b > a)
{
    Console.WriteLine($"Большее число   {b}");
}
else if (a==b)
{
    Console.WriteLine($"Оба числа равны   {a = b}");
}

