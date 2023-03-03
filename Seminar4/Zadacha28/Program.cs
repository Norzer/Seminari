Console.Write("Enter number n ");
//int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[8];
int sluchainaya_velichina = 0;
Random rand = new Random();
for (int i = 0; i < 8; i++)
{
                array[i] = sluchainaya_velichina.Next(0, 2); 
                Console.Write(array[i]);
}
