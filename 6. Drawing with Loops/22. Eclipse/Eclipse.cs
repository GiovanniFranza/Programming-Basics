using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;

            Console.WriteLine(" {0} {1} {0} ", new string('*', width - 2), new string(' ', n - 1));

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', width - 2), new string('-', n - 1));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', width - 2), new string(' ', n - 1));
                }                
            }

            Console.WriteLine(" {0} {1} {0} ", new string('*', width - 2), new string(' ', n - 1));
        }
    }
}
