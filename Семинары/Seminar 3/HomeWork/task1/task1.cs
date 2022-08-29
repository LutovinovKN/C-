// Задача №1 (Не важно, сколько будет цифр в числе, код покажет, полиндром это или нет)

int value = new Random().Next(10000, 100000); // Рандомное 5-ти значное число
Console.WriteLine($"Случайное число = {value}");

//int value = 12321; // Проверка полиндромом

int digitCount = (int)Math.Log10(value) + 1;
Console.WriteLine(digitCount); // Показывает из скольки цифр состоит число

for (int i = 1; i < ((digitCount / 2) + 1); i++)
{
    if (((value % (Convert.ToInt32(Math.Pow(10, digitCount))) / (Convert.ToInt32(Math.Pow(10, digitCount - 1))))) == (value % (Convert.ToInt32(Math.Pow(10, i) / (Convert.ToInt32(Math.Pow(10, i - 1)))))))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Полиндром");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Не полиндром");
    }
}

