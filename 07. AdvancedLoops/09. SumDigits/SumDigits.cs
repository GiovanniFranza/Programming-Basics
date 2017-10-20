using System;

namespace _09.SumDigits
{
    public class SumDigits
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum = sum + (n % 10);
                n = n / 10;
            } while (n > 0);
            Console.WriteLine(sum);
        }
    }
}
