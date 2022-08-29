// Задача №2

// public static double Sqrt (double d); возвращает корень квадратный от заданного числа

Console.Write("Введите координаты (x, y, z) точки A через пробел: ");
string[] nums_str = Console.ReadLine().Split();
int[] point_a = new int[nums_str.Length];
for (int i = 0; i < nums_str.Length; i++)
{
    point_a[i] = Convert.ToInt32(nums_str[i]);
}
Console.Write("Введите координаты (x, y, z) точки B: ");
nums_str = Console.ReadLine().Split();
int[] point_b = new int[nums_str.Length];
for (int i = 0; i < nums_str.Length; i++)
{
    point_b[i] = Convert.ToInt32(nums_str[i]);
}
Console.Write("Расстояние между точками равно: ");
Console.WriteLine(Math.Sqrt(Math.Pow(point_b[0] - point_a[0], 2) +
Math.Pow(point_b[1] - point_a[1], 2) +
Math.Pow(point_b[2] - point_a[2], 2)));

//______________________________________________________________
// Дальше код честно стыренный с просторов интернета
// _____________________________________________________________

// using System;

// class GFG
// {

//     // Function for
//     // distance
//     static void distance(float x1, float y1,
//                         float z1, float x2,
//                         float y2, float z2)
//     {
//         double d = Math.Pow((Math.Pow(x2 - x1, 2) +
//                             Math.Pow(y2 - y1, 2) +
//                              Math.Pow(z2 - z1, 2) *
//                                     1.0), 0.5);
//         Console.WriteLine("Distance is " + d);
//         return;
//     }

//     // Driver code
//     public static void Main()
//     {
//         Console.Write("Введите х координату точка А: ");
//         float x1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите y координату точка А: ");
//         float y1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите z координату точка А: ");
//         float z1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите х координату точка B: ");
//         float x2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите y координату точка B: ");
//         float y2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите z координату точка B: ");
//         float z2 = Convert.ToInt32(Console.ReadLine());

//         // function call
//         // for distance
//         distance(x1, y1, z1,
//                 x2, y2, z2);
//     }
// }


