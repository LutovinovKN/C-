// Задача №1

//! Задать массив заполненный случайными положительными трехзначными  числами.
//! найти количество чётных элементов в массиве

Console.Write("Введите необходимое кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine(String.Join(",", array));
Console.WriteLine(count);

