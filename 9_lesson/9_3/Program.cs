// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int SumOfNumbers(int num)
{
    if (num == 0) return 0;
    return SumOfNumbers(num / 10) + num % 10;
}
Console.WriteLine(SumOfNumbers(673));