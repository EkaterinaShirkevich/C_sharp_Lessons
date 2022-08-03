// программа выводит массив из 8 эл-тов, заполненный 0 и 1 в случайном порядке

void Random01Array(int num)
{
    int[] array= new int[num];
    for(int i=0; i<num; i++)
    {
        array[i]=new Random().Next(0,2); // 2 не захватывает, идет от 0 до 1
        Console.WriteLine($"{array[i]} ");
    }
}
Random01Array(8);