int[] CreateAndFillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

/*void Counter (int[] array, int count)
{
    //int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0)
       {
        count++;
       }
    }
    //Console.WriteLine("------------"); 
    //return count;
}

void PrintCounter (int k)
{
    Console.WriteLine(k); 
}*/
Console.WriteLine("Введите количество чисел, которые вы будуте вводить");
int S = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------------------------------"); 
int count = 0;
int[] arr = new int[S];
CreateAndFillArray(S);
for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] > 0)
       {
        count++;
       }
    }
//int[] arr = new int[S];
//Console.WriteLine(Counter(arr, K));
Console.WriteLine(count);
//PrintCounter(K);


