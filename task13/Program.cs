// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
string userString="";
Console.WriteLine("Введите    целое положительное    число ");
userString = Console.ReadLine();
int dl=userString.Length;
if (dl<=2)  
    Console.WriteLine("Третьей цифры нет "); 
Console.WriteLine($"длина числа  {dl} ");
Console.WriteLine($"Третья цифра= {userString[2]} ");

