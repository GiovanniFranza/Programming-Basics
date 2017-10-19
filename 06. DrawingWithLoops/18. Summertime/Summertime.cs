using System;

namespace _18.Summertime
{
    public class Summertime
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string(' ', ((2 * n) - (n + 1)) / 2), new string('*', n + 1));

            int front = ((2 * n) - (n + 1)) / 2;
            int middle = n - 1;
            for (int i = 1; i <= n - 1; i++)
            {
                if (i <= (n + 1) / 2)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string(' ', front), new string(' ', middle));
                }
                else
                {
                    front--;
                    middle += 2;
                    Console.WriteLine("{0}*{1}*{0}", new string(' ', front), new string(' ', middle));
                }
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
            }
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
