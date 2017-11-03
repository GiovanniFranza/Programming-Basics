using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 1;

        if (n % 2 == 0)
        {
            stars++;
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                Console.Write(new string('-', (n - stars) / 2));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', (n - stars) / 2));
                stars = stars + 2;
            }
        }
        else
        {
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                Console.Write(new string('-', (n - stars) / 2));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', (n - stars) / 2));
                stars = stars + 2;
            }
        }

        for (int i = 0; i <= n / 2 - 1; i++)
        {
            Console.Write("|");
            Console.Write(new string('*', n - 2));
            Console.WriteLine("|");
        }
    }
}