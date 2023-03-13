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

void Multiplication(int[,] matrix1, int[,] matrix2, int[,]matrix3, int rows, int columns)
{
    //int[,] matrix3 = new int[rows, columns];
    for (int i = 0; i < matrix1.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) // columns
        {
            matrix3[i, j] = 0;

            for (int k = 0; k < matrix2.GetLength(0)-1; k++)
            {
                matrix3[i, j] = matrix1[i, k] * matrix2[k, j]+matrix1[i,k+1]*matrix2[k+1,j];
            }
        }
    }
    //return matrix3;
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




Console.WriteLine("Размерность Матриц : ");
Console.Write("Введите количество строк = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matr1 = CreateMatrixRndInt(a, b, 0, 15);
int[,] matr2 = CreateMatrixRndInt(a, b, 0, 15);
int[,] matr3 = new int[a,b];
PrintMatrix(matr1);
Console.WriteLine("------------------- ");
PrintMatrix(matr2);
Console.WriteLine("------------------- ");
Multiplication(matr1, matr2, matr3, a, b);
PrintMatrix(matr3);

