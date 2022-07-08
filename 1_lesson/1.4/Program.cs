// Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
int i=0;
if(a<0)
i=-a;
while(i<=a)
{
    Console.WriteLine(i);
    i++;
}
