// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Gipotinuza (int x1, int y1, int z1, int x2, int Y2, int z2)
{

    int x = x1-x2;
    int y = y1-Y2;
    int z = z1- z2;
    double c = Math.Sqrt (x*x+y*y+z*z);
    return c;

}











Console.WriteLine("Введите ординату Х1 ");
int x1ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату Y1 ");
int y1ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату z1 ");
int z1ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату Х2 ");
int x2ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату Y2 ");
int y2ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату z2 ");
int z2ordin=Convert.ToInt32(Console.ReadLine());
double result=Gipotinuza(x1ordin, y1ordin, z1ordin, x2ordin, y2ordin,z2ordin);
double resround = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resround);
