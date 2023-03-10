//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8
int Stepen(int number1, int number2)
{
    if (number2 == 0 ) return 1;
    else return number1 * Stepen(number1, number2 - 1);
}

Console.WriteLine("Введите число A");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int num2 = int.Parse(Console.ReadLine());
int s = Stepen(num1, num2);
Console.WriteLine(s);