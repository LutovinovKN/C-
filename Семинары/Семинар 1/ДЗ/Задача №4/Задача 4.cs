// Задача №4

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int[] ar = { number1, number2, number3 };
int maxValue = ar.Max<int>();
Console.WriteLine(maxValue);