// По двум координатам точки
// найти расстояние между ними.
// Округлить до двух знаков после
// запятой

double Gipotinuza (int x1, int y1, int x2, int Y2)
{

    int x = x1-x2;
    int y = y1-Y2;
    double c = Math.Sqrt (x*x+y*y);
    return c;

}
Console.WriteLine("Введите ординату Х ");
Console.WriteLine("X1:   ");
int x1ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату Y ");
Console.WriteLine("Y1:   ");
int y1ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату Х ");
Console.WriteLine("X2:   ");
int x2ordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату Y ");
Console.WriteLine("Y2:   ");
int y2ordin=Convert.ToInt32(Console.ReadLine());
double result=Gipotinuza(x1ordin, y1ordin, x2ordin, y2ordin);
double resround = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resround);

