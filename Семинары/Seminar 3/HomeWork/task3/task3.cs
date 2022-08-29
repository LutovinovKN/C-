// Задача №3

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

int i = 0;
int num = 1;
while (i < N)
{
    array[i] = Convert.ToInt32(Math.Pow(num, 3));
    Console.Write(array[i] + " ");
    num++;
    i++;
}
