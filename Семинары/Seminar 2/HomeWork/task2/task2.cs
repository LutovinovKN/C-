// Задача №2
Console.ForegroundColor = ConsoleColor.Green;
int value = new Random().Next(1, 65537);

//int value = 78;

int digitCount = (int)Math.Log10(value) + 1;

Console.WriteLine(digitCount);

Console.WriteLine($"Случайное число = {value}");
if (value < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int digit_third = (value % (Convert.ToInt32(Math.Pow(10, digitCount - 2)))) / (Convert.ToInt32(Math.Pow(10, digitCount - 3))); // нахождение 3 цифры
    Console.WriteLine($"Третьей цифрой из случайного числа является цифра {digit_third}");
}