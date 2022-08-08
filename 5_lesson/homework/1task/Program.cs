// Задайте массив заполненный случайными положительными трёхзначными числами
// Напишитепрограмму, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
        arr_1[i] = new Random().Next(99, 1000);
    }
    return arr_1;
}

int MultNums(int [] arr_1)
{
    int count=0;
    for(int i=0; i<arr_1.Length; i++)
    if(arr_1[i]%2==0)
    count++;

    return count;
}

int[] arr_2 = MassNums(4);
Print(arr_2);
Console.WriteLine(MultNums(arr_2));