// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

int MaxDigit(int Number) //MaxDidit - название, которое мы даем методу(функции), Number - название, кот. мы даем переменной
{
    if(Number/10>Number%10)
       return Number/10;
    else
       return Number%10;
}
int a=new Random().Next(10,100); 
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a)); //вызываем метод