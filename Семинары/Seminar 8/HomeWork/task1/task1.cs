// Задача №1

//! Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//! Например, задан массив:
//!    1 4 7 2
//!    5 9 2 3
//!    8 4 2 4
//!    5 2 6 7
//! Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//? Задать двумерный массив (пользователь может сам задать размер массива)
Console.WriteLine("Введите размер массива (строка / столбец, через пробел, напрмер (3 4)): ");
string[] matrix = Console.ReadLine().Split();
int i_cor = int.Parse(matrix[0]);
int j_cor = int.Parse(matrix[1]);
int[,] arr = new int[i_cor, j_cor];

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
    //? Заполнить массив рандомными числами
    Console.WriteLine("Массив со случайными числами:");
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

RandomArr(arr);
PrintArr(arr);

////////////////////////////////////////////
//? цикл суммирования строки в массиве (временная переменная суммы и запоминания строки (n+1))

int minimum = 999;
int count = 1;
// Номер строки:
int k = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{

    int summ = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {

        int tmp = 0;
        tmp = arr[i, j];
        // Console.WriteLine(tmp);
        summ += tmp;
    }
    // Console.WriteLine($"Сумма равна{summ}");
    if (minimum < summ)
    {
        continue;
    }

    else if (minimum == summ)
    {
        k = i + 1;
        count += 1;
        continue;
    }

    else
    {
        minimum = summ;
        k = i + 1;
    }
    Console.WriteLine(summ);
}
Console.WriteLine($"Минимальное значение  в строке {k}. Всего в массиве Минимальное значение встречается {count} раз. ");

