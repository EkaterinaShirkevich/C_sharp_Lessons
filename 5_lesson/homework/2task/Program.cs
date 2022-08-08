// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 67] -> 0

void Print(int[] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr_1[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr_1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr_1[i] = new Random().Next(1, 10);
    }
    return arr_1;
}

int Sum (int [] arr_1)
{
    int sum=0;
    for(int i=0; i<arr_1.Length; i++)
    if(arr_1[i]%2!=0)
    sum+=arr_1[i];

    return sum;
}

int[] arr_2 = MassNums(4);
Print(arr_2);
Console.WriteLine(Sum(arr_2));