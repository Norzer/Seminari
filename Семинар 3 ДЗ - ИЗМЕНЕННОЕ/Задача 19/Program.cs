Console.Write("Введите 5-значное число: ");
string num1 = Console.ReadLine();
char[] num2 = new char[6];
string numb2 = null;

if (num1.Length != 5) 
{
    Console.WriteLine("EROR!!!!!!!!!!!!!!!!");
}

//Console.WriteLine("Ваше число в обратном виде");
int j = 0;
for (int i = num1.Length - 1; i > -1; --i, j++)
    {
        //Console.Write((num1[i]));
        num2[j] = num1[i];
    }           
numb2 = new string(num2);
//Console.Write(num2);
int a = 0;
//int number1 = Convert.ToInt32(num1);
//int number2 = int.Parse(num2.ToString());
a = (String.Compare(numb2, num1));
//Console.WriteLine(a);
if (a == 0)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
//Console.WriteLine(numb2.Equals(num1));

/*if (number2 == number1)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}*/
