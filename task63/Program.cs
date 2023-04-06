// Зад.63. Задать значение N. Вывести Вывести
// все натуральные числа от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine ("Введите значение N");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write ($" N = {num}:  ");
Outnaturalnumbers (num);
void Outnaturalnumbers ( int n)
{
    if (n == 0) return;
    Outnaturalnumbers (n-1);
    Console.Write($"{n}  ");

}
 