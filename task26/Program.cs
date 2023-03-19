// Ввести число и подсчитать
// количество цифр числа
Console.WriteLine("Введите натуральное число ");
int chi = Convert.ToInt32(Console.ReadLine());
int result = Kolzi (chi);
Console.WriteLine($"Количество цифр числа  {chi} = {result} ");
int Kolzi (int num)
{
    int count = 0;
    while (num > 0)
    {   
        count++;
        num  /= 10; 
        
    }

    return count;
}