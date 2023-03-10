//Напишите программу, которая
//1. на входе спрашивает число,
//2. на выходе дает его квадрат, например:
//4 вывод 16
//-3 вывод 9
//-7-> 49
Console.Write("Введите целое число");
int number=Convert.ToInt32(Console.ReadLine());
int square=number*number;
Console.WriteLine($"Квадрат числа{number}={square}");

