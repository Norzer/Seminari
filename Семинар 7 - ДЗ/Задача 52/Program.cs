int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns]; // 0 , 1
  Random r = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++) // rows
  {
    for (int j = 0; j < matrix.GetLength(1); j++) // columns
    {
      matrix[i, j] = r.Next(min, max + 1) ;//
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
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
        else Console.Write($"{matrix[i, j], 5}");
      }
    Console.WriteLine("|");
  }
}

double Srednee(int[,] matrix, int rows)
{
  double s = 0;
  for (int i = 0; i < matrix.GetLength(1); i++) // columns
  {
    for (int j = 0; j < matrix.GetLength(0); j++) // rows 
    {
      s += matrix[j, i];//
    }
    s = s / rows;
    Console.WriteLine($"Среднее арифметическое столбца "+ i +" = " + s);
    s = 0;
  }
  return s;
}



Console.WriteLine("Размерность Матрицы: ");
Console.Write("Введите количество строк = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Минимальный Диапозон заполнения числа = ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Максимальный Диапозон заполнения числа = ");
int d = Convert.ToInt32(Console.ReadLine());
int[,] matr = CreateMatrixRndInt(a, b, c, d);
PrintMatrix(matr);
double sr = Srednee(matr, a);
