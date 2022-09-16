// Задача №3

//! Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
//! Напишите программу, которая будет построчно выводить массив.
//! Вариант создания функции:
//! Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
//! Пример:
//! Массив размером 3 x 3
//!     10 11 55
//!     33 41 23
//!     17 28 34

Console.Clear();

//? Задать двумерный массив (пользователь может сам задать размер массива)
Console.WriteLine("Введите размер матрицы (строка / столбец, через пробел, например (3 4)): ");
string[] matrix = Console.ReadLine().Split();
int i_cor = int.Parse(matrix[0]);
int j_cor = int.Parse(matrix[1]);
if (i_cor * j_cor > 50)
{
    Console.WriteLine("Количество элементов массива превышают допустимое значение, введите массив с количеством элементов не болеее 50: ");
    return;
}
int[,] arr1 = new int[i_cor, j_cor];

Random rnd = new Random();

int FoundNumber(int[,] array, int numb)
{
    int countRepeatNumb = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[m, k] == numb)
            {
                countRepeatNumb++;
            }
        }
    }
    return countRepeatNumb;
}

void RandomArr(int[,] arrname)
{
    for (int i = 0; i < arrname.GetLength(0); i++)
    {
        for (int j = 0; j < arrname.GetLength(1); j++)
        {
            // вводим ограничение в цифрах от 10 до 99
            arrname[i, j] = rnd.Next(10, 100);

        }
    }
}

void PrintArr(int[,] arrname)
{
    for (int i = 0; i < arrname.GetLength(0); i++)
    {
        for (int j = 0; j < arrname.GetLength(1); j++)
        {
            Console.Write("{0} ", $" {arrname[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] results = new int[i_cor, j_cor];
//? Заполнить массив рандомными числами
//Console.WriteLine("Массив со случайными числами:");
for (int i = 0; i < results.GetLength(0); i++)
{

    for (int j = 0; j < results.GetLength(1); j++)
    {
        int tmpNumb = rnd.Next(10, 100);
        int SearchRepeatedNumber = FoundNumber(results, tmpNumb);
        // Console.Write($"{tmpNumb}\t");
        if (SearchRepeatedNumber > 0)
        {
            j--;
        }
        else
        {
            results[i, j] = tmpNumb;
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
Console.WriteLine("\nВаш массив готов:");
RandomArr(results);
PrintArr(results);


