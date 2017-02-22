namespace _06.SquareOfStars
{
    using System;

    public class SquareOfStars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n));

            for (int i = 2; i <= n - 1; i++)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }

            Console.WriteLine(new string('*', n));
        }
    }
}
