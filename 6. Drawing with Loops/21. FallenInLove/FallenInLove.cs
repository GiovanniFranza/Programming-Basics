using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.FallenInLove
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = 2 * n;
            int midDots = 2;
            int slash = n;

            Console.WriteLine("##{0}##{0}##", new string('.', 2 * n));
            for (int i = 1; i <= n - 1; i++)
            {
                dots -= 2;
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', i), new string('.', dots), new string('.', midDots));
                midDots += 2;
            }
            dots--;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', dots), new string('~', slash--), new string('.', midDots));
                dots += 2;
                midDots -= 2;
            }
            Console.WriteLine("{0}####{0}", new string('.', (n * 2) + 1));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.', (2 * n) + 2));
            }
        }
    }
}
