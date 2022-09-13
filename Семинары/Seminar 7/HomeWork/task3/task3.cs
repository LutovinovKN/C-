// Задача №3

//!Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//! Например, задан массив:
//!   1 4 7 2
//!   5 9 2 3
//!   8 4 2 4
//! Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размер массива (строка / столбец, через пробел, напрмер (3 4)): ");
string[] matrix = Console.ReadLine().Split();
int i_cor = int.Parse(matrix[0]);
int j_cor = int.Parse(matrix[1]);
int[,] arr = new int[i_cor, j_cor];

Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        // вводим ограничение в цифрах от 0 до 9
        arr[i, j] = rnd.Next(1, 10);
    }
}

Console.WriteLine("Массив со случайными числами:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        // выводим массив на экран
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
//? Нужно сделать цикл по столбцам, сделть ещё один массив и вносить среднеарифм. в отдельную ячейку

// Пустой массив размером количеству столбцов
double[] avr = new double[j_cor];
for (int j = 0; j < arr.GetLength(1); j++)
{
    double summ = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double tmp = 0;
        tmp = arr[i, j];
        //Console.WriteLine(tmp);
        summ += tmp;
    }
    avr[j] = summ / i_cor;
}
Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
Console.WriteLine(string.Join("\t", avr));