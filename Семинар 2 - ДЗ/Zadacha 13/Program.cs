Console.Write("Enter number");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("3 number : " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}