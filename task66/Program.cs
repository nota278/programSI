// Задача 66: Задайте значения M и N. Напишите 
// программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine ("Введите значение M ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение N");
int num2 = Convert.ToInt32(Console.ReadLine());
bool natur1 = Natural (num1);
bool natur2 = Natural (num2);
if (natur1 && natur2) 
{
SumNaturalElementsInterval (num1, num2);
}
int sum = SumNaturalElementsInterval (num1, num2);
Console.WriteLine ($"Cумма элементов интервала =   {sum}");

// Console.WriteLine ($"Сумма элементов интервала  {sum}");

bool Natural ( int n)
{
    if ((n % n==0) && (n % 1==0) &&(n>=0) ) return true;
    // && (n2 >= 0 && n2 % 1 =0)) 
    else return false;

}




int SumNaturalElementsInterval (int n1, int n2)

{
    
    
    if (n1==n2 ) return n2;
    
    if (n1<n2)    return n1 + SumNaturalElementsInterval (n1 + 1, n2); 
    
    if (n1>n2)    return n1 + SumNaturalElementsInterval (n1 - 1, n2); 
    else return n1;
}   
        // Console.Write ($"{n1}  ");
       
        
    
//     if (n1>n2 )
         
//     {       
       
//         SumNaturalElementsInterval (n1 - 1, n2) + n1;        
//         Console.Write ($"{n1}  ");
//     }
//     else 
//     {
//     Console.Write ($"{n1}  ");
//     }
    
// }