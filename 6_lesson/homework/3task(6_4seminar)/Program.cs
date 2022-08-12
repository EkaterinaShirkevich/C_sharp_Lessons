// программа создает копию заданного массива (массив дробных чисел) с помощью 
//поэлементного копирования 

void Print(double[] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr_1[i]} ");
    }
    Console.WriteLine();
}

double [] MassNums(int size)
{
    double[] arr_1 = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr_1[i] = new Random().NextDouble();
    }
    return arr_1;
}

