// Задача №2

//? на вход подаётся число и выдаёт сумму цифр в числе, которые являются делителями этого числа.
//! т.е нужно взять число, перебрать каждую его цифру и если число делится на цифру без остатка внести эту цифру в массив
//! Далее сделать сумму элементов в массиве.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());          //? ввод числа
//int num = 452;
int tmp = num;                                          //? копия числа с удаляемой последней цифрой
int digit = 0;

int digitCount = (int)Math.Log10(num) + 1;              //? нахождение количества цифр
int[] divider = new int[digitCount];                    //? массив для делителей размером количества цифр

Console.WriteLine(string.Join(",", divider));           //! потом удалить

for (int i = 0; i < digitCount; i++)
{
    Console.WriteLine(string.Join(",", divider));       //! потом удалить

    digit = tmp % 10;                                   // берётся последняя цифра
    if (digit == 0)                                     // если цифра == 0, то перейти на следующую цифру, на 0 делить нельзя
    {
        tmp /= 10;
        continue;
    }
    else if (tmp / digit == 0)                          // если num / на последнюю цифру == 0
    {
        divider[tmp] = digit;//! ЗДЕСЬ ОШИБКА
        tmp /= 10;                     // то последнюю цифру внести в массив divider
    }
    else
    {
        tmp /= 10;
        continue;
    }
    tmp /= 10;                                          // удалить последнюю цифру
}
Console.WriteLine(string.Join(",", divider));           //! потом удалить
int Sum = 0;
for (int i = 0; i < digitCount; i++)
{
    Sum += divider[i];
}
Console.WriteLine("Сумма=" + Sum);
