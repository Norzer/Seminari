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

void Poryadok(int[,] matrix, int temp)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            for (int k = i + 1; k < matrix.GetLength(0); k++)
            {
                if (matrix[j, i] > matrix[j, k])
                {
                    temp = matrix[j, i];
                    matrix[j, i] = matrix[j, k];
                    matrix[j, k] = temp;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

Console.WriteLine("Размерность Матрицы: ");
Console.Write("Введите количество строк = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matr = CreateMatrixRndInt(a, b, 0, 15);
int c = 0;
PrintMatrix(matr);
Console.WriteLine("----------- ");
Poryadok(matr, c);
PrintMatrix(matr);