// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] FillMatrixSpiral(int rows, int columns)
{
    int[,] massive2D = new int[rows, columns];
    int n = rows;
    int m = columns;
    int i = 0, j = 0;

    int iStart = 0, iFinish = 0,
        jStart = 0, jFinish = 0;

    for (int k = 1; k <= n * m; k++)
    {
        massive2D[i, j] = k;
        if (i == iStart && j < m - jFinish - 1)
        {
            j++;
        }
        else if (j == m - jFinish - 1 && i < n - iFinish - 1)
        {
            i++;
        }
        else if (i == n - iFinish - 1 && j > jStart)
        {
            j--;
        }
        else
        {
            i--;
        }

        if (i == iStart + 1 && j == jStart && jStart != m - jFinish - 1)
        {
            iStart++;
            iFinish++;
            jStart++;
            jFinish++;
        }
    }
    return massive2D;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

Console.WriteLine("Укажите количество строк в двумерном массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в двумерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] spiralMatrix = FillMatrixSpiral(row, column);
PrintMatrix(spiralMatrix);