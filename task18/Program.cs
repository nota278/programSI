// По номеру четверти
// показать диапазон изменения
// координат точки (x,y)
Console.WriteLine("Введите номер четверти");
int chet=Convert.ToInt32(Console.ReadLine());
string result= Koord (chet);
Console.WriteLine(result);

string Koord (int ch)
{
    if (ch==1) return "x > 0, y > 0";
    if (ch==2) return "x < 0, y > 0";
    if (ch==3) return "x < 0, y < 0";
    if (ch==4) return "x > 0, y < 0";
    return "Введена некорректная четверть";

}    

