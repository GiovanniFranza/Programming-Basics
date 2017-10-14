using System;

namespace _03.EvenOrOdd
{
    public class EvenOrOdd
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
