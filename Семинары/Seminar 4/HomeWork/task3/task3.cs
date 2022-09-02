// Задача №3

//! Назвать число ИНТЕРЕСНЫМ если его произведение цифр делится на их сумму. 
//! Написать программу, которая заполняет массив на N ИНТЕРЕСНЫХ случайных чисел.

Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] interest = new int[n];

for (int i = 0; i < n; i++)
{
    int value = new Random().Next(1, 100); // Рандомное число
    //Console.WriteLine($"Случайное число = {value}");
    int digitCount = (int)Math.Log10(value) + 1;              //? нахождение количества цифр
    int tmp = value;
    int digit = 0;
    int composition = 1; // Произведение
    int summ = 0;
    for (int j = 0; j < digitCount; j++)
    {
        digit = tmp % 10;
        if (digit != 0)
        {
            composition *= digit;
            summ += digit;
        }
        tmp /= 10;
    }
    if (composition % summ == 0)
    {
        interest[i] = value;
    }
    else
    {
        i--;
    }
}
Console.WriteLine(String.Join(",", interest));