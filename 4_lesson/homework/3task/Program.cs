// Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] EightMass (int numbers)
{
    int[] array= new int[numbers];
    for(int i=0; i<numbers; i++)
    array[i] = new Random().Next();
    return array;
}

void Print (int[] arrayP)
{
    for(int j=0; j<arrayP.Length; j++)
    Console.Write($"{arrayP[j]}, ");
}

Print(EightMass(8));
