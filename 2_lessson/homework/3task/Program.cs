//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber(int num)
{
    if(num<100)
    {
        Console.WriteLine("Enter correct number");
        return;
    }
    while(num>999)
    num=num/10;
    Console.WriteLine(num%10);
}
Console.WriteLine("Enter the number: ");
int num =int.Parse(Console.ReadLine());
ThirdNumber(num);