// Задача №1

//! Задать двумерный массив размером m x n, заполнить случайными вещественными числами (m = 3, n = 4)

double[,] nums = new double[3,4];

Random rnd = new Random();
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = Math.Round(rnd.NextDouble() * 100, 2); 
        Console.Write("{0,1:F4}", nums[i, j] + "; ");
    }
    Console.WriteLine();
}
