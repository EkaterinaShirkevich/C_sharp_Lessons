// // 2. Задайте двумерный массив. Найдите элементы,
//    у которых обе позиции чётные, и замените эти элементы на их квадраты.

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

int[,] ReplaceElOn2ndPos2xArray(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)   //arr.GetLength(0) это row
    {
        for (int j = 1; j < arr.GetLength(1); j += 2) //arr.GetLength(1) это column
        {
            arr[i, j] *= arr[i, j];
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return (arr);
}
int[,] arr1 = MassNums(4, 4, -10, 10);
Print(arr1);
ReplaceElOn2ndPos2xArray(arr1);
Print(arr1);
