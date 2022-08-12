//пользователь вводит с клавиатуры М чисел
//посчитать, сколько чисел больше 0 ввел пользователь

Console.WriteLine("Enter space-separated numbers");
string words = Console.ReadLine();

while (words.Length == 0)
{
    Console.WriteLine("There is no numbers, try again");
    words = Console.ReadLine();
}

int[] arr = Array.ConvertAll(words.Split(), int.Parse);;
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
        count++;
}
Console.WriteLine($"{count}");
