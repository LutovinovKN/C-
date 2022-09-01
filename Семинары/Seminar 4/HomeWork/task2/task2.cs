// Задача №2

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());          //? ввод числа
int tmp = num;                                          //? копия числа с удаляемой последней цифрой
int digit = 0;

int digitCount = (int)Math.Log10(num) + 1;              //? нахождение количества цифр
int[] divider = new int[digitCount];                    //? массив для делителей размером количества цифр

for (int i = 0; i < digitCount; i++)
{
    digit = tmp % 10;                                   // берётся последняя цифра
    if (digit == 0)                                     // если цифра == 0, то перейти на следующую цифру, на 0 делить нельзя
    {
        tmp /= 10;
        continue;
    }
    else if (num % digit == 0)                          // если num / на последнюю цифру == 0
    {
        divider[i] = digit;
        tmp /= 10;                     // то последнюю цифру внести в массив divider
    }
    else
    {
        tmp /= 10;
        continue;
    }
}

int Sum = 0;
for (int i = 0; i < digitCount; i++)
{
    Sum += divider[i];
}
Console.WriteLine("Сумма=" + Sum);
