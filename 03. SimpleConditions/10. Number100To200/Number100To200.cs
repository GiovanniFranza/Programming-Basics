using System;

namespace _10.Number100To200
{
    public class Number100To200
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (100 <= number && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
