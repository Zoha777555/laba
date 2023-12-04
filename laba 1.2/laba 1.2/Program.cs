// See https://aka.ms/new-console-template for more information

/*
 1 задание
 public class Program
{
    public static void Main()
    {
        int[] array = new int[100];
        int startValue = 300; 

        for (int i = 0; i < 100; i++)
        {
            array[i] = startValue;
            startValue -= 3; 
        }


        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
    }
}
*/

/*
 2 задание
 public class Program
{
    public static void Main()
    {
        int[] array = new int[100];
        int oddNumber = 1;

        for (int i = 0; i < 100; i++) 
        {
            array[i] = oddNumber;
            oddNumber += 2; 
        }


        foreach (int num in array) 
        {
            Console.Write(num + " ");
        }
    }
}*/


/* 3 задание
 public class Program
{
    static void Main() 
{
    int n = 4; 

    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            if (i == 0 || j == 0) 
            {
                matrix[i, j] = 1;
            } else {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
 }*/



/*
 4 задание
 public class Program
{
    static void Main()
    {
        double[,] temperatures = new double[12, 30];


        Random random = new Random();
        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = random.Next(-10, 21); 
            }
        }

        int[] averageTemperatures = CalculateAverageTemperatures(temperatures);


        Console.WriteLine("Неотсортированный массив средних температур:");
        foreach (int temp in averageTemperatures)
        {
            Console.WriteLine(temp);
        }

        Array.Sort(averageTemperatures);

       
        Console.WriteLine("\nОтсортированный массив средних температур:");
        foreach (int temp in averageTemperatures)
        {
            Console.WriteLine(temp);
        }
    }

    static int[] CalculateAverageTemperatures(double[,] temperatures)
    {
        int[] averageTemperatures = new int[12];

        for (int month = 0; month < 12; month++)
        {
            double sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperatures[month, day];
            }
            averageTemperatures[month] = (int)Math.Round(sum / 30);
        }

        return averageTemperatures;
    }
}*/


/*
 
 5 задание
 public class Program
{
    static void Main()
    {
        double[,] temperatures = new double[12, 30];

       
        Random random = new Random();
        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = random.Next(10, 21); 
            }
        }

        Dictionary<string, int> averageTemperatures = CalculateAverageTemperatures(temperatures);

       
        Console.WriteLine("Неотсортированный словарь средних температур:");
        foreach (var kvp in averageTemperatures)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}°C");
        }

      
        var sortedTemperatures = averageTemperatures.OrderBy(kvp => kvp.Key);

       
        Console.WriteLine("\nОтсортированный словарь средних температур:");
        foreach (var kvp in sortedTemperatures)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}°C");
        }
    }

    static Dictionary<string, int> CalculateAverageTemperatures(double[,] temperatures)
    {
        Dictionary<string, int> averageTemperatures = new Dictionary<string, int>();

        string[] months = 
        {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
        };

        for (int month = 0; month < 12; month++)
        {
            double sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperatures[month, day];
            }
            averageTemperatures.Add(months[month], (int)Math.Round(sum / 30));
        }

        return averageTemperatures;
    }
}*/





