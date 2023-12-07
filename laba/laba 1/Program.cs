/*1 Задание 
 class Program
{
    static void Main()
    {

        int[] numbers = new int[10];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }


        Console.WriteLine("Сгенерированный массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();


        int minIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[minIndex])
            {
                minIndex = i;
            }
        }


        Console.WriteLine($"Номер минимального элемента: {minIndex}");
    }
}
*/



/*   2 задание 
 public class Program
{
    public static void Main()
    {
        int[] numbers = new int[0];
        int number;
        int sum = 0;
        int product = 1;
        int count = 0;

        Console.WriteLine("Введите числа (для завершения ввода введите 0):");
        while ((number = Convert.ToInt32(Console.ReadLine())) != 0)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.GetUpperBound(0)] = number;
        }

        foreach (int num in numbers)
        {
            sum += num;
            product *= num;
            count++;
        }

        double average = (double)sum / count;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Среднее: {average}");
    }
}
*/

/* 3 задание
 public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите элементы списка (для завершения введите пустую строку):");

        string input;
        string shortest = "";
        string longest = "";
        bool isFirst = true;

        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            if (isFirst)
            {
                shortest = input;
                longest = input;
                isFirst = false;
            }
            else
            {
                if (input.Length < shortest.Length)
                {
                    shortest = input;
                }
                if (input.Length > longest.Length)
                {
                    longest = input;
                }
            }
        }

        Console.WriteLine($"Самый короткий элемент: {shortest}");
        Console.WriteLine($"Самый длинный элемент: {longest}");
    }
}
*/




/* 4 задание
public class Program
{
    public static void Main()
    {
        Random random = new Random();
        Console.WriteLine("Введите начало и конец диапазона чисел:");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int[] CreateRandomArray(int minValue, int maxValue)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        int[] randomArray = CreateRandomArray(start, end);

        foreach (int num in randomArray)
        {
            Console.Write(num + " ");
        }
    }
}
*/

/* 5 задание 
public class Program
{
    public static void Main()
    {
        Console.WriteLine("введите слова");
        string words = Console.ReadLine();
        int a = 1;

        foreach (var sym in words)
        {
            if (sym == ' ')
            {
                a++;
            }
        }

        Console.WriteLine($"всего слов {a}");
        Console.Write($"Start {words} End");
    }
}
*/