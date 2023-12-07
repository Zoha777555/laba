// See https://aka.ms/new-console-template for more information


/*
 1 задание
 
class Program
{
    static void Main()
    {
        string path = @"C:\Users\Public.COPP\Desktop\numsTask2.txt";
        string[] lines = File.ReadAllLines(path)[0].Split(" ");

        int[] numbers = Array.ConvertAll(lines, s => int.Parse(s));

        int minValue = numbers.Min();

        int minValueIndex = Array.IndexOf(numbers, minValue);
        long product = 1;
        for (int i = minValueIndex + 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        Console.WriteLine("Произведение элементов после минимального значения: " + product);
    }
}
*/
/*
 2 задание
 
class Program
{
    static void Main()
    {
        string path = @"C:\Users\Public.COPP\Desktop\numsTask2.txt";
        string[] lines = File.ReadAllLines(path);
        string[] numbersStr = lines[0].Split(';');
        double[] numbers = Array.ConvertAll(numbersStr, s => double.Parse(s));

        Array.Sort(numbers);

        string sortedNumbers = string.Join(";", numbers.Select(n => n.ToString()));

        File.WriteAllText(path, sortedNumbers);
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
        string content = File.ReadAllText(path);
        string[] numbersStr = content.Split(' '); 
        int[] numbers = Array.ConvertAll(numbersStr, s => int.Parse(s));

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        if (minIndex != -1 && minIndex < numbers.Length - 1)
        {
            int[] numbersAfterMin = numbers.Skip(minIndex + 1).ToArray();
            double average = numbersAfterMin.Average();
            Console.WriteLine("Среднее арифметическое чисел после минимального: " + average);
        }
        else
        {
            Console.WriteLine("В файле нет чисел после минимального.");
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
        string path = @"C:\Users\Public.COPP\Desktop\numsTask2.txt";
        string content = File.ReadAllText(path);
        string[] numbersStr = content.Split(' '); 
        int[] numbers = Array.ConvertAll(numbersStr, s => int.Parse(s));

        int max = numbers.Max();
        int sum = numbers.Where(n => Math.Abs(n - max) == 1).Sum();

        Console.WriteLine("Сумма элементов, отличающихся от максимального на 1: " + sum);
    }
}
*/

/*
 5 задание
class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\Public.COPP\Desktop\numsTask2.txt";
        string fileContent = File.ReadAllText(filePath);
        int[] numbers = fileContent.Split(' ').Select(int.Parse).ToArray();

        int minIndex = Array.IndexOf(numbers, numbers.Min());
        int maxIndex = Array.IndexOf(numbers, numbers.Max());

        int start = Math.Min(minIndex, maxIndex) + 1;
        int end = Math.Max(minIndex, maxIndex);

        double sum = 0;
        for (int i = start; i < end; i++)
        {
            sum += numbers[i];
        }

        int count = end - start;
        double average = sum / count;
        Console.WriteLine("Среднее арифметическое элементов между минимальным и максимальным: " + average);
    }
}
*/