// На вход подается число А
// на выходе получить сумму
// чисел от 1 до А

Console.WriteLine("Введите натуральное число");
int chi=Convert.ToInt32(Console.ReadLine());
int sumnum= SumNumbers(chi);
Console.WriteLine($"Сумма чисел от А до {chi} = {sumnum}");

int SumNumbers(int num)
{  
    
    int sum = 0;
    for (int i = 1; i <= num; i++) 
    {
        sum += i;

    }

        return sum;  



}       
