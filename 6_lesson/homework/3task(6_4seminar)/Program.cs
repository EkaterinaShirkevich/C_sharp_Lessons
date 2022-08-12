// программа создает копию заданного массива (массив дробных чисел) с помощью 
//поэлементного копирования 

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 20) - 10, 2);
    }
    return (arr);
}

double[] Copy(double[] arr)
{
    double[] new_arr = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        new_arr[i] = arr[i];
    return (new_arr);
}
double[] arr_1 = MassNums(8, 3, 9);
Print(arr_1);
double[] arr_1_new = Copy(arr_1);
Print(arr_1_new);