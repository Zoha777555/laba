// See https://aka.ms/new-console-template for more information

/*
 1 задание
class Program
{
    public static void Main()
    {
        string filePath = @"C:\Users\Public.COPP\Desktop\numsTask2.txt";
        string content = File.ReadAllText(filePath);
        string[] words = content.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word);
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
        string filePath = "C:\\Users\\Public.COPP\\Desktop\\numsTask2.txt";
        string[] lines = File.ReadAllLines(filePath);
        string combinedString = string.Join(" ", lines);
        Console.WriteLine(combinedString);
    }
}
*/


/*
 3 задание
class Program
{
    static void Main()
    {
        double a;

        Console.WriteLine("введите число ");
        a = Convert.ToDouble(Console.ReadLine());

        if (a % 2 == 0 && a % 10 == 0 )
        {
            Console.WriteLine("число молодец");
            
        }

        else
        {
            Console.WriteLine("число плохое");
        }
        

    }
}
*/

/*
 4 задание
class Program
{
    static void Main()
    {
        int a;
        int sum = 0;

        Console.WriteLine("Введите положительное число a:");
        a = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("Введите положительное число (для выхода введите отрицательное число):");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            if (number % a == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine($"Сумма чисел, делящихся на {a} нацело, равна {sum}");
    }
}
*/


/*
 5 задание
class Program
{
    static void Main()
    {
        int[,] originalMatrix = { {1, 0, 1}, {0, 1, 0}, {1, 1, 1} };

        int rows = originalMatrix.GetLength(0);
        int cols = originalMatrix.GetLength(1);

        int[,] modifiedMatrix = new int[rows, cols + 1];

        for (int i = 0; i < rows; i++)
        {
            int countOnes = 0;
            for (int j = 0; j < cols; j++)
            {
                modifiedMatrix[i, j] = originalMatrix[i, j];
                if (originalMatrix[i, j] == 1)
                {
                    countOnes++;
                }
            }
            modifiedMatrix[i, cols] = (countOnes % 2 == 0) ? 0 : 1;
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols + 1; j++)
            {
                Console.Write(modifiedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/

/*
 6 задание
class Program
{
    static void Main()
    {
        double[] originalArray = { 1, -2, 3, -4, 5, -6, 7, -8 };

        var positiveArray = originalArray.Where(x => x > 0).ToArray();
        var negativeArray = originalArray.Where(x => x < 0).ToArray();

        Console.WriteLine("Положительные элементы:");
        foreach (var item in positiveArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nОтрицательные элементы:");
        foreach (var item in negativeArray)
        {
            Console.Write(item + " ");
        }
    }
}
*/