int Pow(int a , int b) 
{
    int c = 1; 
    for ( int i = 0; i < b ; i++)
    {
        c *= a;
        //Console.WriteLine("----" + c);
    }
    return c;
}


Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Степень");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Pow(num1, num2));


