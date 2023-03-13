//1. На вход подаются два числа 
//2. Является ли одно число 
// квадратом другого
Console.WriteLine("Введите первое число ");
int first=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int second=Convert.ToInt32(Console.ReadLine());
bool result= Squart(first, second);
Console.WriteLine(result ? "да" : "нет");
bool Squart(int num1, int num2)
{
    return (num1*num1==num2 ||num2*num2==num1);

}