// Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.Write("Enter the Number: ");
int Number=int.Parse(Console.ReadLine());
if (Number>5)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
if(Number>7)
{
    Console.WriteLine("Error");
}



