// Задача 42. Написать программу, которая будет
// переводить десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine ("Введите десятичное  число ");
int decimal1 = Convert.ToInt32(Console.ReadLine());
string result = DecToBinString (decimal1);
Console.WriteLine (result);
// Console.WriteLine ("Введите десятич.  число ");
// int binmal2 = Convert.ToInt32(Console.ReadLine());
// int res =DecToBinInt (binmal2);
// Console.WriteLine (res);

string DecToBinString (int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber.ToString ();
    }

    string dec = string.Empty;
    while (decimalNumber > 0)
    {
        dec = decimalNumber%2 + dec;
        decimalNumber/=2;
    }

    return dec;

}   

//  int DecToBinInt (int decimalNumber)
//  {

//     if (decimalNumber==0 || decimalNumber==1)
//     {
//     return decimalNumber;
//     }
//     int dec = 0;
//     int i = 1;
//     while (decimalNumber > 0)
//     {
//       dec = dec + decimalNumber%2 *i;
//        i *=10;

//     }
//      return dec;
 
//  }




