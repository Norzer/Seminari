// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random r = new Random();
int k = 0;


void FullArray(int[] array)
{
  for (int i = 0; i < n; i++)
  {
    array[i] = r.Next(100, 999);
    //Console.WriteLine(array[i] + " ");
  }
}

void SumChet( int[] array) 
{
    for (int i = 0; i < n; i++)
    {
        if ( array[i] % 2 == 0)
        {
           k = k + 1;
        }
        else
        {
           continue;
        };
    }

 Console.WriteLine(k);
}

FullArray(array);
SumChet(array);