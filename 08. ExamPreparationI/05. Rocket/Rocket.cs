using System;

namespace _05.Rocket
{
    public class Rocket
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int with = 3 * n;

            int dot = (with - 2) / 2;
            int space = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dot), new string(' ', space));
                dot--;
                space += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', with - 2 * (n / 2)));
            for (int i = 1; i <= n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', with - 2 - 2 * (n / 2)));
            }

            int half = n / 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', half), new string('*', with - 2 - 2 * (half)));
                half--;
            }
        }
    }
}
