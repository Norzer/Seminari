Console.Write("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

int StartNum = 2;

if(num > 1)
{
    while(StartNum <= num)
    {
        Console.Write(StartNum + " ");
        StartNum = StartNum + 2;
    }
}