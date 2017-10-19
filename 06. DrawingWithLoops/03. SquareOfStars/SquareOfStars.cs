using System;

namespace _03.SquareOfStars
{
    public class SquareOfStars
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= n; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
