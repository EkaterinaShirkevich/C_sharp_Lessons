// программа принимает на вход число и выдает кол-во цифр в числе

void Lenght(int a)
{
    string num = a.ToString(); //преобразуем число в строку
    Console.WriteLine(num.Length);
}
Lenght(1670);