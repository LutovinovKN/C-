// Задача №3

//! Задать массив натуральных чисел, Найти разницу между max и min значениями

Console.Write("Введите необходимое кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int maximum = 0;
int minimum = 99;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 100);
    // Console.WriteLine(array[i]);
    if (array[i] > maximum)
    {
        maximum = array[i];
    }
    else if (array[i] < minimum)
    {
        minimum = array[i];
    }
}
Console.WriteLine(String.Join(",", array));
int difference = maximum - minimum;
Console.WriteLine($"Разнаца чисел {maximum} и {minimum} равна {difference}");