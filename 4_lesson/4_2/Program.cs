// программа принимает число N и выдвет произведение чисел от 1 до N

int Method(int num)
{
    int allsum=1;
    for( int i=1; i<=num; i++)
    allsum=allsum*i;
    return allsum;
}
Console.WriteLine(Method(5));
