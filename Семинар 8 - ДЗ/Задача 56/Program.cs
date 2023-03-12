int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0 , 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int MinSumRows(int[,] matrix, int temp)
{
    int min = 100000;
    int s = 0;
    for (int i = 0; i < matrix.GetLength(1); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(0); j++) // columns
        {
            for (int k = 0; k < matrix.GetLength(1) ; k++)
            {
                s += matrix[j, k];
            }
            if ( min > s )
            {
                min = s;
                s = 0;
                continue;
            }
            else
            {
                s = 0;
                continue;
            }
            
        }
    }
    return min;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("Размерность Матрицы: ");
Console.Write("Введите количество строк = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matr = CreateMatrixRndInt(a, b, 0, 10);
int c = 0;
PrintMatrix(matr);
Console.WriteLine(MinSumRows(matr, c));