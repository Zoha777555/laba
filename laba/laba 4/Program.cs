// See https://aka.ms/new-console-template for more information


/*
 
 задание 1
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое положительное число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }

        Console.WriteLine("Произведение натуральных чисел, кратных трём и не превышающих число n: " + product);
        Console.ReadLine();
    }
}
*/
/*
 2 задание
 
class Program
{
    static void Main()
    {
        string filename = "C:\\Users\\Public.COPP\\Desktop\\numsTask2.txt";

        try
        {
            string[] numbers = File.ReadAllText(filename).Split(';');
            double sumOfPositiveNumbers = 0;

            foreach (string number in numbers)
            {
                if (Double.TryParse(number, out double n) && n < 0)
                {
                    break;
                }
                if (Double.TryParse(number, out double num))
                {
                    if (num > 0)
                    {
                        sumOfPositiveNumbers += num;
                    }
                }
            }
            Console.WriteLine("Сумма всех положительных элементов последовательности: " + sumOfPositiveNumbers);
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка: " + e.Message);
        }
    }
}

*/
/*
 3 задание
class Program
{
    static void Main()
    {
        try
        {
            string filepath = @"C:\Users\Public.COPP\Desktop\numsTask2.txt"; 
            string contents = File.ReadAllText(filepath);
            string[] numbersStr = contents.Split(',');
            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            int min = numbers.Min();
            int max = numbers.Max();

            double ratio = (double)min / max;

            Console.WriteLine("Отношение минимального к максимальному: " + ratio);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка: " + e.Message);
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
        string filePath = @"C:\Users\Public.COPP\Desktop\numsTask2.txt";
        string content = File.ReadAllText(filePath);
        string[] numbers = content.Split(' ');

        int count = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                count++;
            }
            else
            {
              
                count = 1;
            }
        }

        Console.WriteLine("Количество одинаковых рядом стоящих чисел: " + count);
    }
}
*/

/*
 5 задание
class Program
{
    static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Введите координату x: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату y: ");
        b = Convert.ToDouble(Console.ReadLine());

        if (a >= -1 && a <= 3 && b >= -2 && b <= 4)
        {
            Console.WriteLine($"Точка ( {a}  ,  {b}  ) принадлежит заштрихованной области.");
        }
        else
        {
            Console.WriteLine("Точка (" + a + ", " + b + ") не принадлежит заштрихованной области.");
        }

        Console.ReadLine();
    }
}
*/

/*
 6 задание
using System.Globalization;

namespace Program5
{
    class Program5   
    {
        public static void Main()      
        {
            Console.WriteLine("Введите число x: ");        
            float numX = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Введите число y: "); 
            float numY = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);        
            if (( ((numY - 2) / 2.5f) <= numX && ((numY - 2) / -2.5f) >= numX ) && (numY >= -3 && numY <= 2))
            {
                Console.WriteLine("Точка входит в эту область");
                
            }
            else          
            {
                Console.WriteLine("Точка не входит в эту область");
                
            }
        }
        
    }
}
*/