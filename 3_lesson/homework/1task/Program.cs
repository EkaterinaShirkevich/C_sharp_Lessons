// : Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
//палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

void Palindrome(int a)
{
    if(a/1000==(a%10)*10+(a%100)/10)
    {
        Console.WriteLine("This is palindrome");
    }
    
    else
    {
        Console.WriteLine("This is not palindrome");
    }
}
Palindrome(12821);