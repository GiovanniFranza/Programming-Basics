using System;

namespace _04.TriangleOfDollars
{
    public class TriangleOfDollars
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
