// Зад.67. Программа принимает на вход число
// и возващает сумму его цифр.
// 453 -> 12
// 45 - > 9

Console.WriteLine ("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits (number);
Console.WriteLine ($"Сумма цифр числа {number} -> {sum}");
int SumDigits (int num)
{
    if (num == 0) return 0;
    else return SumDigits (num/10) + num%10;
 

}