// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите натуральное число A");
int chiA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int chiB = Convert.ToInt32(Console.ReadLine());
int result = Stepen (chiA, chiB);
Console.WriteLine($"  {chiA}  в степени  {chiB} = {result}");
int Stepen (int a, int b)
{
    int p = a;
    for (int i = 1; i < b; i++)
    {
         p = p*a;
    }


    return p;

}