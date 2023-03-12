
int[] array = new int[8];
Random r = new Random();

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(100);
    }
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++ )
    {
        Console.WriteLine(arr[i]);
    }
}
FillArray(array);
Print(array);

