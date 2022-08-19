//Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumOfNumbers(int a, int b)
{
    if (b < a) return 0;
    return SumOfNumbers(a, b - 1) + b;
}
Console.WriteLine(SumOfNumbers(1, 15));