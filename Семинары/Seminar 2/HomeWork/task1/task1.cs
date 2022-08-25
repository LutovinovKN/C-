// Задача №1

int value = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число = {value}");
int digit_second = (value % 100) / 10; // нахождение 2 цифры
Console.WriteLine($"Второй цифрой из случайного числа является цифра {digit_second}");

//Console.WriteLine(value > 99 ? value.ToString()[1] : '-'); //Альтернатива :)