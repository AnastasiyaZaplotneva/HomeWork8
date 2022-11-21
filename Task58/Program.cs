// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixProduct = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixProduct[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return matrixProduct;
}

Console.WriteLine("Укажите количество строк в первом двумерном массиве: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в первом двумерном массиве: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество строк во втором двумерном массиве: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов во втором двумерном массиве: ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMassive2D = FillMatrixRndInt(row1, column1, 1, 10);
int[,] secondMassive2D = FillMatrixRndInt(row2, column2, 1, 10);
PrintMatrix(firstMassive2D);
Console.WriteLine();
PrintMatrix(secondMassive2D);

if(column1 != row2)
{
    Console.WriteLine("Эти матрицы нельзя перемножить");
}
else
{
    int[,] massive2DProduct = MatrixProduct(firstMassive2D, secondMassive2D);
    Console.WriteLine();
    PrintMatrix(massive2DProduct);
}
