// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
int i=2;
if(i>a)
{
    Console.WriteLine(a-1);
}
while(i<=a)
{
    Console.WriteLine(i);
    i=i+2;
}
