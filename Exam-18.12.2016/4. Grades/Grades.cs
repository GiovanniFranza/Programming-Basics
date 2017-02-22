using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double average = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                average += num;
                if (num >= 2.00 && num <= 2.99)
                {
                    p1++;
                }
                else if (num >= 3.00 && num <= 3.99)
                {
                    p2++;
                }
                else if (num >= 4.00 && num <= 4.99)
                {
                    p3++;
                }
                else if (num >= 5.00)
                {
                    p4++;
                }
            }
            Console.WriteLine("Top students: {0:F2}%", (p4 / n) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", (p3 / n) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (p2 / n) * 100);
            Console.WriteLine("Fail: {0:F2}%", (p1 / n) * 100);
            Console.WriteLine("Average: {0:F2}", average / n);
        }
    }
}
