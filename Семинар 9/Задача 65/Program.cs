// задайте значения M и N. Напишите программу которая выведет все натуральные числа в промежутке от M и N.

Console.WriteLine("Введите натуральное число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int number2 = int.Parse(Console.ReadLine());

NaturaleNumber(number1 , number2);

void NaturaleNumber(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");// - хвостовая рекурсия
        NaturaleNumber(num1 - 1, num2);
    }
    else
    {
        NaturaleNumber(num2 - 1, num1);
        Console.Write($"{num2} ");
    }
}
