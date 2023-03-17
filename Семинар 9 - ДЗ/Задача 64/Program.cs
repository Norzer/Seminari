//добавить проверку

Console.WriteLine("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 0 )  NaturaleNumber(number);
else Console.WriteLine("ОШИБКА") ;

void NaturaleNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num}"); //- хвостовая рекурсия
    NaturaleNumber(num - 1);
}