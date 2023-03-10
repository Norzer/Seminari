Console.WriteLine("Введите число до которого будут указаны кубы ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);

void Cube(int numb)
{
    int i = 1;
    while (i <= numb)
    {
        Console.WriteLine($"{i} - {i * i * i}");
        i++;
    }
}