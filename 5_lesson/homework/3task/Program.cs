// : Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7, 22, 2, 78] -> 76

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

double MaxMin (double [] arr_1)
{
    double Min = arr_1[0];
    double Max = arr_1[0];
    for(int i=1; i < arr_1.Length; i++)
    if(arr_1[i]<Min)
        Min = arr_1[i];
    else if(arr_1[i]>Max)
        Max = arr_1[i];    

    return (Max-Min);   
}

double [] arr_2 = MassNums(4);
Print(arr_2);
Console.WriteLine(MaxMin(arr_2));