// Задача №4

int value = new Random().Next(1, 1000001);

//int value = 1288; // это кратное число, для проверки

Console.WriteLine($"Случайное число = {value}");

if ((value % 7 == 0) && (value % 23 == 0))
{
    Console.WriteLine("Случайное число кратно 7 и 23");
}

else
{
    Console.WriteLine("Случайное число не кратно 7 и 23");
}