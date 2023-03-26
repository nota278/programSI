// Написать программу, которая вводит
// три числа и проверяет, существует ли 
// треугольник с такими сторонами
// (теоремао неравенстве треугольника: каждая сторона
// меньше суммы двух других сторон).

Console.WriteLine ("Введите  первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите  второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите  третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
bool result = DoesaTriangeExist (num1, num2, num3);
Console.WriteLine (result);

bool DoesaTriangeExist (int n1, int n2, int n3)
{
    if (n1<n2+ n3 && n2<n1+n3 && n3<n1+n2)
    {
        return true;
    }
    return false;

}
