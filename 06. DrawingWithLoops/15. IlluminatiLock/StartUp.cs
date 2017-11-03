using System;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        //Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));

        for (int i = 1; i <= n / 2; i++)
        {
            int firstDots = n - (2 * i);
            int thirdDots = n - 2;
            int secondDots = ((3 * n) - 6 - (2 * firstDots) - thirdDots) / 2;
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', firstDots), new string('.', secondDots),
                new string('.', thirdDots));
        }

        for (int i = n / 2; i > 0; i--)
        {
            int firstDots = n - (2 * i);
            int thirdDots = n - 2;
            int secondDots = ((3 * n) - 6 - (2 * firstDots) - thirdDots) / 2;
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', firstDots), new string('.', secondDots),
                new string('.', thirdDots));
        }

        //Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
    }
}