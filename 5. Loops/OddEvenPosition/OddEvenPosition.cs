using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sumOdd = 0;
            double sumEven = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    sumEven += num;
                }
                else
                {
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if(num < oddMin)
                    {
                        oddMin = num;
                    }
                    sumOdd += num;
                }
            }
            Console.WriteLine("Oddsum = {0},", sumOdd);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("Oddmin = No,");
            }
            else
            {
                Console.WriteLine("Oddmin = {0},", oddMin);
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax = No,");
            }
            else
            {
                Console.WriteLine("OddMax = {0},", oddMax);
            }
            Console.WriteLine("Evensum = {0},", sumEven);
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("Evenmin = No,");
            }
            else
            {
                Console.WriteLine("Evenmin = {0},", evenMin);
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("Evenmax = No");
            }
            else
            {
                Console.WriteLine("Evenmax = {0}", evenMax);
            }
        }
    }
}
