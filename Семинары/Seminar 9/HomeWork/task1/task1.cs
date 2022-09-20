// Задача №1

//! Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//!     1 4 7 2             7 4 2 1
//!     5 9 2 3     -->     9 5 3 2
//!     8 4 2 4             8 4 4 2

class Program
{
    static void Main(String[] args)
    {
        var a = new Int32[3, 4];

        var random = new Random();
        for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
        {
            for (var j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = random.Next(100);
                Console.Write("{0,4}", a[i, j]);
            }
        }
        Console.WriteLine("");

        //сортируем
        for (var i = 0; i < a.GetLength(0); i++)
            //сортировка пузырьком
            for (var j = 0; j < a.GetLength(1); j++)
                for (var k = 0; k < a.GetLength(1); k++)
                {
                    if (a[i, j] <= a[i, k]) continue;
                    var temp = a[i, j];
                    a[i, j] = a[i, k];
                    a[i, k] = temp;
                }

        for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
            for (var j = 0; j < a.GetLength(1); j++)
            {
                Console.Write("{0,4}", a[i, j]);
            }
    }
}
