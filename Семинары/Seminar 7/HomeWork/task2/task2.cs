// Задача №2

//! Написать программу, которая на вход позиции (две) элемента
//! в двумерном массиве и возвращает значение этого элемента
//! или же указание, что такого элемента нет.

// Создать рандомный массив (пользователь может задать размер массива/матрицы)
Console.WriteLine("Введите размер матрицы (через пробел, напрмер (3 4)): ");
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

Console.WriteLine("Создаём массив со случайными числами:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        // выводим массив на экран
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine("");
}

// Далее нужно пользователю вписать через пробел необходимую ячейку

Console.Write("Введите ячейку, значение которой хотите увидеть: ");
string[] element = Console.ReadLine().Split();
int i_place = int.Parse(element[0]);
int j_place = int.Parse(element[1]);
if (i_place < i_cor & j_place < j_cor)
{
    Console.Write($"\n{arr[i_place, j_place]}\n");
}
else
{
    Console.Write("Такого числа нет, вы вышли за пределы массива \n");
}

//Console.WriteLine(string.Join(",", arr));
