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
else Console.WriteLine($"Введенное число не 5-значное");