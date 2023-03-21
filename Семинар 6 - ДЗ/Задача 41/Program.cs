int[] CreateAndFillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int Counter (int[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0)
       {
        count++;
       }
    }
    //Console.WriteLine("------------"); 
    return count;
}

void PrintCounter (int k)
{
    Console.WriteLine(k); 
}
Console.WriteLine("Введите количество чисел, которые вы будуте вводить");
int S = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------------------------------"); 
//int K = 0;
int[] arr = new int[S];
CreateAndFillArray(S);
//int[] arr = new int[S];
Console.WriteLine(Counter(arr));
//PrintCounter (K);


