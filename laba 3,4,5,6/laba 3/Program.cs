// See https://aka.ms/new-console-template for more information

/*
1 задание
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\Public.COPP\Desktop\input.txt");

        int[] chosenNumbers = lines[0].Split(' ').Select( arg => Int32.Parse(arg)).ToArray();

        int n = Int32.Parse(lines[1]);

        using (StreamWriter outputFile = new StreamWriter(@"C:\Users\Public.COPP\Desktop\output.txt"))
        {
            for (int i = 2; i < n + 2; i++)
            {

                int[] ticketNumbers = lines[i].Split(' ').Select(arg => Int32.Parse(arg)).ToArray();
                int matchingNumbers = ticketNumbers.Intersect(chosenNumbers).Count();
                if (matchingNumbers >= 3)
                {
                    outputFile.WriteLine("Lucky");
                }
                else
                {
                    outputFile.WriteLine("Unlucky");
                }
            }
        }
    }
}
*/


/*
 2 задание
 
class Program
{
    static void Main()
    {
        string input = @"C:\Users\Public.COPP\Desktop\nums.txt";

        string[] pathInput = File.ReadAllLines(input);
        File.WriteAllText(input, string.Empty);
        string write = String.Empty;
        foreach (string elem in pathInput[0].Split(" "))
        {
            if (elem != "" && int.Parse(elem) % 2 != 0)
            {
                write += elem + " ";
            }


        }

        File.WriteAllText(input, write);
    }
}
*/
/*
 3 задание
 
class Program
{
    static void Main()
    {
        string path = @"C:\Users\Public.COPP\Desktop\numsTask2.txt";
        using (StreamReader stream = new StreamReader(path)) 
        {
            
            string s = stream.ReadLine();
            string[] array = s.Split(' ');

            int resultVolume = 0;

            for (int i = array.Length -1 ; i >= 0; i--)
            {
                int perevorot = Convert.ToInt32(array[i]);
                int min = perevorot;
                int volum = 0;
                for (int j = 0; j < i; j++)
                {
                    int perevorot2 = Convert.ToInt32(array[j]);
                    if (perevorot < perevorot2)
                    {
                        min = perevorot;
                    }
                    else
                    {
                        min = perevorot2;
                    }

                    volum = min * (i - j);
                    if (volum > resultVolume)
                    {
                        resultVolume = volum;
                    }


                }
                



            }


       


            Console.WriteLine(resultVolume);

        }






    }
}
*/