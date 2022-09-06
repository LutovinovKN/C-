// Задача №1

//! Программа запрашивает натуральное число М.
//! Пользователь вводит с клавиатуры М чисел.
//! Посчитать сколько чисел больше 0 ввел пользователь

string number = "чис";
//? Рандомное число М
int M = new Random().Next(1, 11);

// Нахождение окончания слова
if (M > 0 && M < 2)
    Console.WriteLine($"Введите {M} " + number + "ло :");
else if (M > 1 && M < 5)
    Console.WriteLine($"Введите {M} " + number + "ла через пробел:");
else if (M == 0 || M > 4 && M <= 10)
    Console.WriteLine($"Введите {M} " + number + "ел через пробел:");

string[] nums_str = Console.ReadLine().Split();
int[] nums_int = new int[nums_str.Length];
for (int i = 0; i < nums_str.Length; i++)
{
    nums_int[i] = Convert.ToInt32(nums_str[i]);
}
int positive = 0;

for (int i = 0; i < M; i++)
{
    if (nums_int[i] > 0)
    {
        positive++;
    }
}
Console.WriteLine(positive);
//int n = Convert.ToInt32(Console.ReadLine());
