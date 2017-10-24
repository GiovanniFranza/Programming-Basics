using System;

namespace _05.Fox
{
    public class Fox
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;

            int star = 1;
            int dash = width - 2 - 2 * star;
            int eye = n / 2;
            int midEye = n;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', star), new string('-', dash));
                star++;
                dash -= 2;
            }
            for (int i = 1; i <= n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', eye), new string('*', midEye));
                eye++;
                midEye -= 2;
            }
            dash += 2;
            star = width - 2 * dash - 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', dash), new string('*', star));
                dash++;
                star -= 2;
            }
        }
    }
}
