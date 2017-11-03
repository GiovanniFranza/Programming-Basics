using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.Write("*");
            for (int j = 1; j < i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        for (int i = 1; i <= n - 1; i++)
        {
            Console.Write(new string(' ', i));
            Console.Write("*");
            for (int j = 1; j < n - i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}