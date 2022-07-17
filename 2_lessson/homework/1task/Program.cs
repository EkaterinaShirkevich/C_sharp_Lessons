// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number(int Num)
{
    return Num/10%10;
}
Console.WriteLine("Enter three-digit number: ");
int num=int.Parse(Console.ReadLine());
if(num>99 && num<1000)
{
   Console.WriteLine(Number(num)); 
}
else
{
   Console.WriteLine("Error, please, try again");
}

    
