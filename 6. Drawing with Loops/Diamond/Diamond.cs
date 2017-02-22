using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //int leftRight = (n - 1) / 2;
            //for (int i = 1; i <= (n - 1) / 2; i++)
            //{
            //    Console.Write(new string('-', leftRight));
            //    Console.Write("*");
            //    var mid = n - 2 * leftRight - 2;
            //    if (mid >= 0)
            //    {
            //        Console.Write(new string('-', mid));
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(new string('-', leftRight));
            //    leftRight--;
            //}

            //Console.Write("*");
            //Console.Write(new string('-', n - 2));
            //Console.WriteLine("*");

            //for (int i = 1; i <= (n - 1) / 2; i++)
            //{
            //    Console.Write(new string('-', leftRight));
            //    Console.Write("*");
            //    var mid = n - 2 * leftRight - 2;
            //    if (mid >= 0)
            //    {
            //        Console.Write(new string('-', mid));
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(new string('-', leftRight));
            //    leftRight++;
            //}
            int num = int.Parse(Console.ReadLine());

            if (num >= 3 && num <= 100)
            {
                if (num % 2 == 1)  // odd number
                {
                    int beg = num / 2;
                    Console.WriteLine("{0}*{0}", new string('-', beg));
                    for (int raw = beg - 1; raw >= (-beg + 1); raw--)
                    {
                        int rawAbs = Math.Abs(raw);
                        Console.WriteLine("{0}*{1}*{0}", new string('-', rawAbs), new string('-', (1 + (beg - rawAbs - 1) * 2)));
                    }
                    Console.WriteLine("{0}*{0}", new string('-', beg));
                }

                else // even number
                {
                    int beg = (num - 1) / 2;

                    for (int raw = beg; raw >= (-beg); raw--)
                    {
                        int rawAbs = Math.Abs(raw);
                        Console.WriteLine("{0}*{1}*{0}", new string('-', rawAbs), new string('-', (beg - rawAbs) * 2));
                    }
                }
            }
            else if (num == 1 || num == 2)
            {
                Console.WriteLine("{0}", new string('*', num));
            }
        }
    }
}
