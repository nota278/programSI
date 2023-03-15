//  По введенным координатам точки
//  определить в каком квадранте
//  она находится
Console.WriteLine("Введите ординату Х ");
Console.WriteLine("X:   ");
int xordin=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ординату Y ");
Console.WriteLine("Y:   ");
int yordin=Convert.ToInt32(Console.ReadLine());
int qwad=Quart(xordin, yordin);
string result = qwad >0 
             ? $"Указанные координаты соответствуют четверти  {qwad} "
             : "Вы ввели некорректные ординаты";
Console.WriteLine(result);            
int Quart(int x, int y)
{
   if (x>0 && y>0) return 1;
   if (x<0 && y>0) return 2;
   if (x<0 && y<0) return 3;
   if (x>0 && y<0) return 4;
   return 0;
}