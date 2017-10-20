using System;

namespace _12.Fibonacci
{
    public class Fibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;

            if (n < 2)
            {
                Console.WriteLine(1);
            }

            for (int i = 1; i <= n - 1; i++)
            {
                var sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
            Console.WriteLine(f1);
        }
    }
}
