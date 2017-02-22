using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int startDash = 3 * n;
            int midDash = 1;
            int endDash = 5 * n - 3 * n - 2;

            Console.WriteLine("{0}**{1}", new string('-', startDash), new string('-', endDash));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', startDash), new string('-', midDash++), new string('-', endDash - i));
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', startDash), new string('-', midDash - 1), new string('-', endDash - (n - 1)));
            }
            for (int i = 1; i <= (n - 2) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', startDash--), new string('-', midDash - 1), new string('-', (5 * n) - startDash - midDash - 2));
                midDash += 2;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', startDash), new string('*', midDash - 1), new string('-', (5 * n) - startDash - midDash - 1));
        }
    }
}
