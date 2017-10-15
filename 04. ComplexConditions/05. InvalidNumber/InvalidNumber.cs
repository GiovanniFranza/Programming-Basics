using System;

namespace _05.InvalidNumber
{
    public class InvalidNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 200 || number == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
