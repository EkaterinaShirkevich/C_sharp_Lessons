// Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями 
//y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Enter b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = double.Parse(Console.ReadLine());

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (k1 - k2) / (b1 - b2);
    double y = k2 * x + b2;
    Console.WriteLine($"{x},{y}");
}
Console.WriteLine(IntersectionPoint());



