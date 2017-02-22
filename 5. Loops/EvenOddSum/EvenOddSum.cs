using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddSum
{
    class EvenOddSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            if (Math.Abs(oddSum - evenSum) == 0)
            {
                Console.WriteLine("Yes sum " + oddSum);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}
