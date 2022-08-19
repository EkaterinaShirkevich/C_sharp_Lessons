// Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""2, 4""
//M = 4; N = 8. -> ""4, 6, 8""

void ValueSet(int min, int max)
{
    if (max < min) return;
    ValueSet(min, max - 1);
    if (max%2==0)
    Console.Write($"{max}, ");
}
ValueSet(7,13);