// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] ArrayWithSummRows(int[,] matrix)
{
int[] array = new int[matrix.GetLength(0)];
int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        array[count] += matrix[i,j];
    }
    count++;
}
return array;
}

void FindingRowIndex(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < array[i-1])
        {
            min = i;
        }
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов равняется {min}"); 
}

int[,] massive2D = FillMatrixRndInt(5, 4, 0, 10);
PrintMatrix(massive2D);
int[] massive = ArrayWithSummRows(massive2D);
FindingRowIndex(massive);