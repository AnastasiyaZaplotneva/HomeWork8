// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] FillMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // 2
{
    for (int j = 0; j < matrix.GetLength(1); j++) //
    {
        matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
    }
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
        else Console.Write($"{matrix[i,j], 5}");
    }
    Console.WriteLine(" |");
}
}
int[,] SortingMatrixInRows(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        for(int k = 0; k < matrix.GetLength(1); k++)
        {
            if(matrix[i,j]>matrix[i,k])
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;    
            }
        }
    }
}
return matrix;
}

int[,] massive2D = FillMatrixRndInt(4, 4, 0, 100);
PrintMatrix(massive2D);
SortingMatrixInRows(massive2D);
Console.WriteLine();
PrintMatrix(massive2D);