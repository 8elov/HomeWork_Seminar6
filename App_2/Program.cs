// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


string GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    return ($"({y1};{y2})");
}

Console.WriteLine(GetIntersectionPoint(b1,k1,b2,k2));