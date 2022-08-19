// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int[,] ReverseFirstEndRow(int[,] arr)
{
    int vrem = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        vrem = arr[0, j]; //переливание - через временную переменную
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = vrem;
    }
    Console.WriteLine();
    return arr;
}
//либо способ кортежа:
//(arr[0,1], arr[row-1,i])=(arr[row-1,i], arr[0,i])



Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);

ReverseFirstEndRow(arr_1);
Print(arr_1);