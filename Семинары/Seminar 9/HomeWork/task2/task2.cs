// Задача №2

//! Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4.
//! Например, на выходе получается вот такой массив:
//!     01 02 03 04
//!     12 13 14 05
//!     11 16 15 06
//!     10 09 08 07

// Console.Clear();

// const int n = 4;
// const int m = 4;
// int[,] matrix = new int[n, m];

// int row = 0;
// int col = 0;
// int dx = 1;
// int dy = 0;
// int dirChanges = 0;
// int visits = m;

// for (int i = 0; i < matrix.Length; i++)
// {
//     matrix[row, col] = i + 1;
//     if (--visits == 0)
//     {
//         visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//         int temp = dx;
//         dx = -dy;
//         dy = temp;
//         dirChanges++;
//     }

//     col += dx;
//     row += dy;
//     Console.Write("{0,2}", matrix[row, col]);
// }




int main()
{
    int a = int Next[4, 4];
    int N, M;

    scanf("%d%d", &N, &M);
    
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M){
        a[i][j] = k;
        if (i == Ibeg && j < M - Jfin - 1)
            ++j;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
            ++i;
        else if (i == N - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1)){
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
    
    for (int i = 0; i < 10; ++i){
        for (int j = 0; j < 10; ++j)
            printf("%3d", a[i][j]);
        printf("\n");
    }

    return 0;
}