int Sum(int num)
{
    int s = 0;
    int k = 0;
    while (num > 0)
    {
        k = num % 10;
        s += k; 
        num = num / 10;
    }
    return s;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));



