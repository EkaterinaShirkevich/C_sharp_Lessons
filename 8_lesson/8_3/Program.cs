// задайте двумерный массив из целых чисел
//напишите программу, которая удалит строку и столбец
//на пересечении которых находится наименьший элемент массива

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

int[] MinSearch(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int min = array[0, 0];
    int[] index = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (min > array[i, j])
                min = array[i, j];
            index[0] = i;
            index[1] = j;
        }
    }
    return index;
}

void DeleteRowColumn (int [,] array, int [] index)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (index [0] == i || index [1] == j)
            continue;

            else
            Console.Write($" {array[i, j]} ");
        }
    } 
    Console.WriteLine();   
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);
int [] new_arr = MinSearch(arr_1);
DeleteRowColumn(arr_1, new_arr);


