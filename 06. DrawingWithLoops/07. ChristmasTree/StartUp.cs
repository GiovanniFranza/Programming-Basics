using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            var spaces = new string(' ', n - i);
            var stars = new string('*', i);
            Console.Write(spaces);
            Console.Write(stars);
            Console.Write(" | ");
            Console.Write(stars);
            Console.WriteLine(spaces);
        }
    }
}