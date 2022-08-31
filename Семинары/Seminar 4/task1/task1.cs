// Задача №1

Console.Write("Необходимо возвести число А в степень В\n");

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

float row = A;
for (int i = 1; i < B; i++)
    row *= A;
Console.WriteLine(row);