int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth]; // 0 , 1, 2
    Random rnd = new Random();
    int x = 10;

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                //matrix[i, j, k] = rnd.Next(min, max + 1);
                matrix[i, j, k] = x;
                x++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i,j,k]}({i},{j},{k})");
            }
        }
     
    }
}


void Check(int rows, int columns, int depth)
{
    if  ( rows * columns * depth > 99)
    {
        Console.WriteLine("ОШИБКА - нарушает условие");
    }
}

Console.WriteLine("Размерность Матриц : ");
Console.Write("Введите количество строк = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину = ");
int c = Convert.ToInt32(Console.ReadLine());
int[,,] matr = CreateMatrixRndInt(a, b, c, 10, 99);
Check(a, b, c);
PrintMatrix(matr);

