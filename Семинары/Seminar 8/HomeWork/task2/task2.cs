// Задача №2

//! Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
//! Например, даны 2 матрицы:
//!     2 4 | 3 4
//!     3 2 | 3 3
//! Результирующая матрица будет:
//!       18 20
//!       15 18

//? Задать двумерный массив (пользователь может сам задать размер массива)
Console.WriteLine("Введите размер матрицы (строка / столбец, через пробел, например (3 4)): ");
string[] matrix = Console.ReadLine().Split();
int i_cor = int.Parse(matrix[0]);
int j_cor = int.Parse(matrix[1]);
if (i_cor != j_cor)
{
    Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.: ");
    return;
}
int[,] arr1 = new int[i_cor, j_cor];
int[,] arr2 = new int[i_cor, j_cor];

Random rnd = new Random();

void RandomArr(int[,] arrname)
{
    for (int i = 0; i < arrname.GetLength(0); i++)
    {
        for (int j = 0; j < arrname.GetLength(1); j++)
        {
            // вводим ограничение в цифрах от 0 до 9
            arrname[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArr(int[,] arrname)
{
    //? Заполнить матрицу рандомными числами
    //Console.WriteLine("Массив со случайными числами:");
    for (int i = 0; i < arrname.GetLength(0); i++)
    {
        for (int j = 0; j < arrname.GetLength(1); j++)
        {
            // выводим массив на экран
            Console.Write($"{arrname[i, j]}\t");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

Console.WriteLine("\nМатрица A:");
RandomArr(arr1);
PrintArr(arr1);
Console.WriteLine("\nМатрица B:");
RandomArr(arr2);
PrintArr(arr2);
Console.WriteLine("\nМатрица C = A * B:");
int[,] C = Multiplication(arr1, arr2);
Print(C);

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}
