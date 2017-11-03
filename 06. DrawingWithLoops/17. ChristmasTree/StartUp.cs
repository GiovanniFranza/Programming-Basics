using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstDots = n;
        int firstCaret = 1;
        for (int i = 1; i <= (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('\'', firstDots--), new string('^', firstCaret));
            firstCaret += 2;
        }

        int secondDots = n - 1;
        int secondCaret = 3;
        for (int i = 1; i <= (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('\'', secondDots--), new string('^', secondCaret));
            secondCaret += 2;
        }

        for (int i = 1; i <= (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}|{1}|{0}", new string('\'', n - 1), new string(' ', 1));
        }
        Console.WriteLine(new string('-', (2 * n) + 1));
    }
}