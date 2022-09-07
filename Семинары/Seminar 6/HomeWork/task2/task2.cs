// Задача №2

//! Написать программу, которая найдёт точку пересеченияя двух прямых, заданных уравнениями.
//! y = k1 * x + b1 | y = k2 * x + b2

Console.WriteLine("Введите значение числа k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y1 = 0;
double y2 = 0;
x = (b2 - b1) / (k1 - k2);
Console.WriteLine($"X = {x}");
y1 = k1 * x + b1;
y2 = k2 * x + b2;
Console.WriteLine($"({y1};{y1})");

if ((k1 * b2 - k2 * b1) == 0)
{
    Console.WriteLine("Прямые параллельны другу друг и не имеют точек пересечения");
}
else if ((k1 * k2 + b1 * b2) == 0)
{
    Console.WriteLine("Прямые перпендикулярны");
}

