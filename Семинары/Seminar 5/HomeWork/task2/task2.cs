// Задача №2

//! Задать одномерный массив, заполненный случайными числами
//! Найти сумму чётных элементов

Console.Write("Введите необходимое кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sumnum = 0;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.WriteLine(array[i]);
    if (array[i] % 2 == 0 && i % 2 != 0)
    {
        sumnum += array[i];
    }
    Console.WriteLine(String.Join(",", array));
}
Console.WriteLine(sumnum);