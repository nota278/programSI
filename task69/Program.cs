// Зад.69. Программа принимает на вход
// два числа А и В и возводит число А
// в целую степень В с помощью рекурсии.
// А = 3, В = 5 -> 243
// A = 2, B = 3 -> 8

Console.WriteLine ("Введите значение первого числа ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение второго числа");
int num2 = Convert.ToInt32(Console.ReadLine());
int degree = DegreeOfNumber (num1, num2);
Console.WriteLine ($" Число {num1} в степени {num2} -> {degree}");

int DegreeOfNumber (int n1, int n2)
{
    if (n2 == 0) return 1;
    else return n1 * (DegreeOfNumber (n1, n2-1));

}