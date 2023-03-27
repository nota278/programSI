// Задача 43: Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Введите  k1 ");
int ka1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите  b1 ");
int be1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите  k2 ");
int ka2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите  b2 ");
int be2 = Convert.ToInt32(Console.ReadLine());
double xord = OrdX (ka1, be1, ka2, be2);
double xround=Math.Round(xord, 1);
double yord = OrdY (xord, ka1, be1);
double yround = Math.Round(yord, 1);
Console.WriteLine($"  Ордината Х {xround} ордината Y  {yround}");

double OrdX (int k1, int b1, int k2, int b2)

{    
    return (b2-b1)/(k1-k2);
    // else
    // {
    //     Console.WriteLine (" k1 и k2 не должны быть равны");
    //     break;

    // }
}  

double OrdY (double x, int k1, int b1)
{

    return k1*x + b1;

}