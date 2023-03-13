int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns]; // 0 , 1
    int k = 1;
    int c = 1;
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        int h = matrix.GetLength(0)-1;
        if (c % 2 == 0)
        {
            do
            {
                for (int j = matrix.GetLength(0) - 1; j > 0; j--, i++) // columns
                {
                    matrix[i, h] = k;
                    k++;
                    //c++;
                    l++;
                    continue;
                } 
            } while (l < matrix.GetLength(1));

            
        }
        else
        {
            do
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // columns
                {
                    matrix[i, j] = k;
                    k++;
                    //c++;
                    l++;
                    //continue;
                } 
            } while (l < matrix.GetLength(0));
        }

        c++;
 









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


int[,] matr1 = CreateMatrixRndInt(4, 4);
PrintMatrix(matr1);