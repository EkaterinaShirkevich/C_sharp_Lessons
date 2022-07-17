// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
void DeleteLast()
{
    int num=new Random().Next(100,1000);
    Console.WriteLine($"{num} - {num/100}{num%10}");
}
DeleteLast();