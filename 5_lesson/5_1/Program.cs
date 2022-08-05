// программа замена эл-тов массива: положит. меняем на соответствующие отрицательные

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{   
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);        
    }    
    return arr;
}

void Change(int [] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i]=arr[i]*-1;
       
    }
}
int[]arr_1=MassNums(12,-9,9);
Print(arr_1);
Change(arr_1);
Print(arr_1);    
