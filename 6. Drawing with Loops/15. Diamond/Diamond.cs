using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = n;
            int middleDots = 3 * n;
            int starts = 1;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', --dots), new string('.', middleDots));
                middleDots += 2;
            }
            Console.WriteLine(new string('*', 5 * n));

            middleDots -= 2;
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots++), new string('.', middleDots));
                middleDots -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', (5 * n) - (2 * dots)));
        }
    }
}
