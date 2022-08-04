//  Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int NumSum (int num)
{
    int sum=0;
    for(int i=1; num>0; i++)
    {
    sum+=num%10;
    num/=10;
    }
    return sum;
}
Console.WriteLine(NumSum(452));