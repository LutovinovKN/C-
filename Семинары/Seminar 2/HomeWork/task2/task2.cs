// Задача №2

int value = new Random().Next(1, 65537);

//int value = 78;

Console.WriteLine($"Случайное число = {value}");
int digit_third = (value % 1000) / 100; // нахождение 3 цифры

if (value < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третьей цифрой из случайного числа является цифра {digit_third}");
}