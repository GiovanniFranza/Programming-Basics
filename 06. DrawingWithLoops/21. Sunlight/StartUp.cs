using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int height = 3 * n;

        Console.WriteLine("{0}*{0}", new string('.', width / 2));

        int secondDots = (width - 5) / 2;
        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', secondDots));
            secondDots--;
        }
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        Console.WriteLine(new string('*', width));
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }

        int firstPart = (n - 1);
        int secondPart = (width - 2 * firstPart - 3) / 2;
        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', firstPart), new string('.', secondPart));
            firstPart--;
            secondPart++;
        }
        Console.WriteLine("{0}*{0}", new string('.', width / 2));
    }
}