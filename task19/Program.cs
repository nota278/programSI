// Напишите программу, которая принимает
// на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Модуль  обработки числа
bool Wwod (string ci, int kol)
{
    int chi = Convert.ToInt32(ci);
    int aver = kol/2;
    // Если четное число цифр-ложь
    //  return (aver=0);
    // int ishodchi = chi;
    int i = 0;
    while (chi>0)
    
        i=i*10;
        i=i+chi%10;
        chi=chi/10;
        
        
    return (chi==i); 

}
Console.WriteLine("Введите число");
string firststring = Console.ReadLine();
Console.Write("Количество цифр Вашего числа =  ");
int kolsvr=firststring.Length;
Console.WriteLine (kolsvr);
bool result= Wwod(firststring, kolsvr );
// Console.Writeline("Результат ");
Console.WriteLine(result ? "да" : "нет");







