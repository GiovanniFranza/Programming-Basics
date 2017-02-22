using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int n = (num / 100) + ((num / 10) % 10);
            int m = (num / 100) + (num % 10);
            int newNumber = num;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= m; col++)
                {
                    if (newNumber % 5 == 0)
                    {
                        newNumber = newNumber - (num / 100);
                    }
                    else if (newNumber % 3 == 0)
                    {
                        newNumber = newNumber - ((num / 10) % 10);
                    }
                    else
                    {
                        newNumber = newNumber + (num % 10);
                    }
                    Console.Write("{0} ", newNumber);
                }
                Console.WriteLine();
            }
        }
    }
}
