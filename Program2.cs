using System;

public class DifferenceCalculator
{
    public static int CalculateDifference(int n)
    {
        int absoluteDifference = Math.Abs(n - 123);

        if (n > 123)
        {
            return absoluteDifference * 3;
        }
        else
        {
            return absoluteDifference;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            int difference = CalculateDifference(n);
            Console.WriteLine($"Абсолютная разность между {n} и 123: {difference}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}