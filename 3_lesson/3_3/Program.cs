// программа принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

void Searching(int a)
{
    int i=1;
    while(i<=a)
    {
        Console.WriteLine(Math.Pow(i,2));
        i++;
    }
}
Searching(7);