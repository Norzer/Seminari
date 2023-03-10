Console.WriteLine("Введите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Random r = new Random();
double razn = 0;
double max = 0;
double min = 1111111110;

void Counter (int[] array, int count)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.WriteLine(array[i] + " ");
       if (array[i] > 0)
       {
        count++;
       }
    }
}


void FillArray(double[] array)
{
  for (int i = 0; i < n; i++)
  {
    array[i] = r.Next(100) + r.NextDouble();
    //Console.WriteLine(array[i] + " ");
  }
}

void Raznica(double[] array)
{
  for (int i = 0; i < n; i++)
  {
    if (array[i] > max)
    {
        max = array[i];
    }
  }
  for (int i = 0; i < n; i++)
  {
    if (array[i] < min)
    {
        min = array[i];
    }
  }

razn = max - min;
Console.WriteLine(razn);
}

FillArray(array);
Raznica(array);