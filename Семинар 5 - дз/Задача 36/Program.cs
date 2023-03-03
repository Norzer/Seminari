Console.WriteLine("Введите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random r = new Random();
int sum = 0;


void FillArray(int[] array)
{
  for (int i = 1; i < n; i++)
  {
    array[i] = r.Next(100);
    Console.WriteLine(array[i] + " ");
  }
}

void SumChet( int[] array) 
{
    for (int i = 1; i < n; i++)
    {
        if ( i % 2 != 0)
        {
           sum = sum + array[i];
        }
        else
        {
           continue;
        };
    }
 Console.WriteLine($"Сумма: ",sum);
}

FillArray(array);
SumChet(array);