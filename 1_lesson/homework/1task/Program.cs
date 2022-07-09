// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());
int max=a;
int min=b;
if(max<b) max=b;
Console.Write("max= ");
Console.Write(max);
if(min>a) min=a;
Console.Write("min= ");
Console.Write(min);