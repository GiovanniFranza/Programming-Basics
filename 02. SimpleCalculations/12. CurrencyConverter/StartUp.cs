using System;

public class StartUp
{
    public static void Main()
    {
        var num = double.Parse(Console.ReadLine());
        var first = Console.ReadLine();
        var second = Console.ReadLine();

        if (first == "BGN")
        {
            if (second == "USD")
            {
                Console.WriteLine("{0} USD", Math.Round(num / 1.79549, 2));
            }
            else if (second == "EUR")
            {
                Console.WriteLine("{0} EUR", Math.Round(num / 1.95583, 2));
            }
            else if (second == "GBP")
            {
                Console.WriteLine("{0} GBP", Math.Round(num / 2.53405, 2));
            }

        }
        if (first == "USD")
        {
            if (second == "BGN")
            {
                Console.WriteLine("{0} BGN", Math.Round(num * 1.79549, 2));
            }
            else if (second == "EUR")
            {
                Console.WriteLine("{0} EUR", Math.Round(num * 0.91802, 2));
            }
            else if (second == "GBP")
            {
                Console.WriteLine("{0} GBP", Math.Round(num * 0.70855, 2));
            }
        }
        if (first == "EUR")
        {
            if (second == "BGN")
            {
                Console.WriteLine("{0} BGN", Math.Round(num * 1.95583, 2));
            }
            else if (second == "USD")
            {
                Console.WriteLine("{0} USD", Math.Round(num * 1.08930, 2));
            }
            else if (second == "GBP")
            {
                Console.WriteLine("{0} GBP", Math.Round(num * 0.77182, 2));
            }
        }
        if (first == "GBP")
        {
            if (second == "BGN")
            {
                Console.WriteLine("{0} BGN", Math.Round(num * 2.53405, 2));
            }
            else if (second == "USD")
            {
                Console.WriteLine("{0} USD", Math.Round(num * 1.41134, 2));
            }
            else if (second == "EUR")
            {
                Console.WriteLine("{0} EUR", Math.Round(num * 1.29564, 2));
            }
        }
    }
}