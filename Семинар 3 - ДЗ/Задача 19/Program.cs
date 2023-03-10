Console.Write("Введите 5-значное число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine("Да.");
  }
  else Console.WriteLine("Нет");
}

if (number.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");


char[] str = s.ToCharArray();
    string a;
    for (int i = str.Length-1; i > -1; --i) 
    {
         a = Convert.ToString(str[i]);
         Console.Write(a);
    }
      Console.ReadKey();
