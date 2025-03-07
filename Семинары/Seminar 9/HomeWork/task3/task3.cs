﻿// Задача №3

//! Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите положительное число M(до 3 включительно):");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите положительное число N(до 4 включительно):");
int numberN = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");