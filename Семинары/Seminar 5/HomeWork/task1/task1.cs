// Задача №1

//! Задать массив заполненный случайными положительными трехзначными  числами.
//! найти сумму чётных элементов, стоящих на нечётных позициях

Console.Write("Введите необходимое кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sumnum = 0;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.WriteLine(array[i]);
    if (array[i] % 2 == 0 && i % 2 != 0)
    {
        sumnum += 1;
    }
    Console.WriteLine(String.Join(",", array));
}
Console.WriteLine(sumnum);

