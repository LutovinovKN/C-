// Задача №1 (Не важно, сколько будет цифр в числе, код покажет, полиндром это или нет)

//int value = new Random().Next(10000, 100000); // Рандомное 5-ти значное число
int value = 12231; // Проверка полиндромом
Console.WriteLine($"Случайное число = {value}");

bool res = false;

int digitCount = (int)Math.Log10(value) + 1;
Console.WriteLine(digitCount); // Показывает из скольки цифр состоит число
//int i = 0;
for (int i = 1; i <= (digitCount / 2); i++)
{
    int left = value % Convert.ToInt32(Math.Pow(10, digitCount - i + 1)) / Convert.ToInt32(Math.Pow(10, digitCount - i));

    int right = value % Convert.ToInt32(Math.Pow(10, i)) / Convert.ToInt32(Math.Pow(10, i - 1));

    if (left == right)  // Сравниваю крайнюю правую цифру с крайней левой цифрой и перемещаюсь на прорядок ближе к центру числа
    // Сравниваю крайнюю левую цифру с крайней правой цифрой и перемещаюсь на прорядок ближе к центру числа
    {
        Console.WriteLine(left);
        Console.WriteLine(right);
        res = true;
    }
    else
    {
        Console.WriteLine(left);
        Console.WriteLine(right);
        res = false;
        break;
    }
}

if (res == true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Полиндром");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Не полиндром");
}

