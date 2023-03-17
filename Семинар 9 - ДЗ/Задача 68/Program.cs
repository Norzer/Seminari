//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9      m = 3, n = 2 -> A(m,n) = 29


/*int NaturaleNumber(int num1, int num2)
{
    int s = 0;
    if (num1 > num2)
    {
        //Console.Write($"{num1} ");// - хвостовая рекурсия
        s += num1;
        NaturaleNumber(num1 - 1, num2);
    }
    else
    {
        NaturaleNumber(num2 - 1, num1);
        s += num2;
        //Console.Write($"{num2} ");
    }
    return s;
}
*/

int Accerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Accerman(m - 1, 1);
    }
    else
    {
        return Accerman(m - 1, Accerman(m, n - 1));
    }
}

Console.WriteLine("Введите натуральное число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(Accerman(number1, number2));
