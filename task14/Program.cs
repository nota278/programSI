// 1. Ввести число
// 2. Проверить, кратно ли оно одновременно
// 7 и 23
//   14 - нет
//   46 - нет
//   161- да
Console.WriteLine("Введите целое число ");
int hi=Convert.ToInt32(Console.ReadLine());
bool result = Multipl(hi,7,23);
Console.WriteLine(result);
bool Multipl (int num, int num1, int num2)
{
    return (num%num1==0 && num%num2==0);
}