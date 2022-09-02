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
    if (digit != 0 && num % digit == 0)                 // если цифра == 0, то перейти на следующую цифру, на 0 делить нельзя
    {
        divider[i] = digit;
    }
    tmp /= 10;                                          // то последнюю цифру внести в массив divider
}

int Sum = 0;
for (int i = 0; i < digitCount; i++)
{
    Sum += divider[i];
}

