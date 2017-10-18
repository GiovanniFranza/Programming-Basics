using System;
namespace _10.HalfSumElement
{
    public class HalfSumElement
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            var num = 0;
            int max = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }

            sum = sum - max;

            if (sum == max)
            {
                Console.WriteLine("Yes, sum = " + max);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sum - max));
            }
        }
    }
}
