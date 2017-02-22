using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            do
            {
                factorial = factorial * n;
                n--;
            } while (n > 0);
            Console.WriteLine(factorial);
        }
    }
}
