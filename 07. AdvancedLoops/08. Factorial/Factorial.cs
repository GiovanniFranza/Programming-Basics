using System;

namespace _08.Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            do
            {
                factorial = factorial * n;
                n--;
            } while (n > 0);
            Console.WriteLine(factorial);
        }
    }
}
