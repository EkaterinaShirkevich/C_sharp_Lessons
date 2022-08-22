//  Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct(int[,] first, int[,] second)
{
    int row = first.GetLength(0);
    int column = first.GetLength(1);
    int[,] pr_matrix = new int[row, column];

    if (row != second.GetLength(0) || column != second.GetLength(1))
        return pr_matrix;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            pr_matrix[i, j] = first[i, j] * second[i, j];
        return pr_matrix;
}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Enter the number of rows2: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns2: ");
int column2 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 8);
Print(arr_1);
int[,] arr_2 = MassNums(row2, column2, 1, 8);
Print(arr_2);
int[,] result = MatrixProduct(arr_1, arr_2);
Print(result);
