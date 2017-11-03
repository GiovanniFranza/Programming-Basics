using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int colSize = n / 2;
        int middleSize = 2 * n - 2 * colSize - 4;
        Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', colSize), new string('_', middleSize));

        for (int i = 1; i <= n - 3; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
        }

        Console.WriteLine("|{0}{1}{0}|", new string(' ', colSize + 1), new string('_', middleSize));
        Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colSize), new string(' ', middleSize));
    }
}