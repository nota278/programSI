// Зад.65. Задать числа M и N. Вывести
// все натуральные числа от М до N.
// M = 1, N = 5 -> 1 2 3 4 5
// M = 4, N = 8 -> 4 5 6 7 8


Console.WriteLine ("Введите значение M ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение N");
int num2 = Convert.ToInt32(Console.ReadLine());
Outnatnumbers (num1, num2 );

void Outnatnumbers (int n1, int n2)
{
    if (n1<n2)
    {
        Console.Write ($"{n1}  ");
        Outnatnumbers (n1 + 1, n2); 
        
    }
    else if (n1>n2)
     
    {        
        
        Outnatnumbers (n1 - 1, n2);        
        Console.Write ($"{n1}  ");
    }
    else 
    {
    Console.Write ($"{n1}  ");
    }
    
}