// неравенство треугольника - программа принимает числа и проверяет
//есть ли треугольник со сторонами такой длины

void Triangle(int x, int y, int z)
{
    if(x+y>z && x+z>y && y+z>x)
        Console.WriteLine("True");
    else
        Console.WriteLine("False");    
}
Triangle(4,2,5);