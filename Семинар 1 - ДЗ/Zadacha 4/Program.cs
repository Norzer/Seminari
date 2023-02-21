

Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3 number");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (number1 > number2) {
    max = number1;
}
else {
max = number2;
}

if (max < number3) {
    max = number3;
}

Console.WriteLine($"max = {max}");
