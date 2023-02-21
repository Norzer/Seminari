Console.Write("Enter number (1,2,3,4,5,6,7) ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
    Console.WriteLine("Yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Eror");
  }
  else Console.WriteLine("No");
}
CheckingTheDayOfTheWeek(dayNumber);
