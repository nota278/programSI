// 
// 
// 
// 
// 

Console.WriteLine("Введите первое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c3=Convert.ToInt32(Console.ReadLine());
int gros=a;
if (gros <= b)
{
    Console.WriteLine($"Промежуточный максимум  {b}");
}
if (b<= c3)
{
     Console.WriteLine($"Большее число  {c3}");
}



