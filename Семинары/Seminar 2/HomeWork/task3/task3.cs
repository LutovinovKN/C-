// Задача №3 

Console.Write("Введите число от 1 до 7 включительно: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 7) || (num < 1))
{
    Console.Write("Вы ввели неверное число, попробуйте снова: ");
}

else if ((num == 7) || (num == 6))
{
    Console.WriteLine("да");
}

else
{
    Console.WriteLine("нет");
}