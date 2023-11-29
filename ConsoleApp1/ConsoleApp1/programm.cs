namespace ConsoleApp1;

public class programm
{
   public static void Main()

   {
     int [,] temper = new int [12,30];

     Random rand = new Random();

     for (int i = 0; i < 12; i++)
     {
         for (int j = 0; j < 30; j++)
         {
             temper[i, j] = rand.Next(-10, 40);
         }
     }


     Console.WriteLine($"{temper}");
     
     

   }


 
    
}