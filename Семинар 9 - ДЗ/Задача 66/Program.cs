//реализовать сумму элементов от N до M или наоборот

int PrintNumber(int num1, int num2, int s)
{
    //int s = 0;
    if (num1 > num2)
    {
        s += num1;
        Console.Write($"===={s}==== ");
        return PrintNumber(num1 - 1, num2, s);
    }
    else if (num2 > num1)
    {
        s += num2;
        Console.Write($"===={s}==== ");
        return PrintNumber(num1, num2 - 1, s);
        //Console.Write($"{num2} ");
        
    }
    else
    {
        return s = num2;
        //Console.Write($"{num2} ");
    }
    //return s += s;
    //Console.WriteLine(s + "ghjdt");
    //return s;
}





Console.WriteLine("Введите натуральное число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int number2 = int.Parse(Console.ReadLine());
int summa = 0;
Console.WriteLine(PrintNumber(number1, number2, summa ));
//3Console.WriteLine("Сумма = " + summa );

