// 1. Задается номер дня недели
// 2. На выходе выводится текстом день недели
// В программе предусмотрена проверка на дуракоустойчивость.
// То есть, если номер дня недели
// выходит за рамки от 1 до 7
Console.WriteLine("Введите номер дня недели");
int a =Convert.ToInt32(Console.ReadLine());
if (a< 1) 
{  
     Console.WriteLine("   Введите правильно номер дня недели от 1 до 7");
}

if (a>7)
{
    Console.WriteLine("   Введите правильно номер дня недели от 1 до 7");
}
else if (a==1)
{
     Console.WriteLine("   Это понедельник");
}
else if(a==2)
{
    Console.WriteLine("   Это вторник");
}
else if (a==3)
{
    Console.WriteLine("   Это среда");
}
else if (a==4)
{
    Console.WriteLine("   Это четверг");
}
else if (a==5)
{
    Console.WriteLine("   Это пятница");    
}
else if (a==6)
{
    Console.WriteLine("   Это суббота");
}
else if (a==7)
    Console.WriteLine("   Это воскресенье");

