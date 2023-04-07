// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine ("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Akkerman (num1, num2);
int result = Akkerman (num1, num2);
Console.WriteLine ($"Функция Аккермана = {result}");

int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    if ((m>0) && (n==0)) return Akkerman (m-1, 1);
    if ((m>0) && (n>0)) return Akkerman (m-1, Akkerman (m, n-1));
    else return 0;
}