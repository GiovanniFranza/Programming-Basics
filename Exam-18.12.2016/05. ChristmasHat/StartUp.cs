using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 4 * n + 1;

        Console.WriteLine("{0}/|\\{0}", new string('.', (width - 3) / 2));
        Console.WriteLine("{0}\\|/{0}", new string('.', (width - 3) / 2));

        int dots = (width - 3);
        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots / 2), new string('-', i));
            dots -= 2;
        }
        Console.WriteLine(new string('*', width));
        for (int i = 1; i <= width; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("*");
            }
            if (i == width)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine(new string('*', width));
    }
}