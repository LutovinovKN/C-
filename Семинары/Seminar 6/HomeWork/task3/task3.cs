// Задача №3

//! Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//! Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//! Если кол-во элементов нечетное, то элемент посередине не учитывать.
//! Результат сложения вывести на экран.

Console.Write("Введите необходимое кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];


int composition = 1;
int summ = 0;


for (int i = 0; i < (n); i++)
{
    array[i] = new Random().Next(1, 10);
    //Console.WriteLine(array[i]);
}

for (int i = 1; i <= (n / 2); i++)
{
    composition = array[i - 1] * array[n - i];
    //Console.WriteLine(composition);
    summ += composition;
}
Console.WriteLine($"Сумма произведений пар чисел = {summ}");
