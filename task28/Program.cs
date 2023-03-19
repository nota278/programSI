// Ввести число N и подсчитать
// произведение чисел от 1 до N 

Console.WriteLine("Введите натуральное число ");
int chi = Convert.ToInt32(Console.ReadLine());
int result = Composition (chi);
Console.WriteLine($"Произведение цифр числа  {chi} = {result} ");
int Composition (int num)
{
    int p = 1;
    
    for (int i = 2; i <=num; i++)
    {
        p = p * i;
    }
    return p;
}