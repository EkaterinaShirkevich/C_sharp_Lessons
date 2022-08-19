// // 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void ValueSet(int min, int max)
{
    if (max < min) return;
    ValueSet(min, max - 1);
    Console.Write($"{max}, ");
}
ValueSet(-9, 8);

