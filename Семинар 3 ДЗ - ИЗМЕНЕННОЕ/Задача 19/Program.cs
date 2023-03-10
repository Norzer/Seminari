Console.Write("Введите 5-значное число: ");
string num1 = Console.ReadLine();
char[] num2 = new char[6];
string numb2 = null;

if (num1.Length != 5) 
{
    Console.WriteLine("EROR!!!!!!!!!!!!!!!!");
}

int j = 0;
for (int i = num1.Length - 1; i > -1; --i, j++)
    {
        
        num2[j] = num1[i];
    }           
numb2 = new string(num2);

int a = 0;
a = (String.Compare(numb2, num1));
if (a == 0)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
