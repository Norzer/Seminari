int[] CreateAndFillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    return array;
}

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

void PrintCounter (int k)
{
    Console.WriteLine(k); 
}
Console.WriteLine("Введите количество чисел, которые вы будуте вводить");
int S = Convert.ToInt32(Console.ReadLine());
int K = 0;
//int[] arr = new int[S];
CreateAndFillArray(S);
int[] arr = new int[S];
Counter (arr, K);
PrintCounter (K);


