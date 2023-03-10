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


void Diapozon(int rows, int columns, int x, int y )
{
    if ( y > rows && x > columns)
    {
        Console.WriteLine("такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine("Такие элементы есть");
    }
}


Console.WriteLine("Размерность Матрицы: ");
Console.Write("Введите количество строк = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matr = CreateMatrixRndInt(a, b, -100, 100);
PrintMatrix(matr);

Console.Write("Введите координату x = ");
int x1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y = ");
int y1 =  Convert.ToInt32(Console.ReadLine());
Diapozon(a, b, x1, y1);