// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру 1-7 ");
int hi=Convert.ToInt32(Console.ReadLine());
bool result = Den(hi);
Console.WriteLine($"День недели {hi} ->  {result}");
bool Den(int num)
{
    
     return (num==6 || num==7);
     
        
}




 

