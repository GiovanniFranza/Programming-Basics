using System;

namespace _15.StupidPassword
{
    public class StupidPassword
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            for (int symbol1 = 1; symbol1 <= n; symbol1++)
            {
                for (int symbol2 = 1; symbol2 <= n; symbol2++)
                {
                    for (var symbol3 = 'a'; symbol3 < 'a' + L; symbol3++)
                    {
                        for (var symbol4 = 'a'; symbol4 < 'a' + L; symbol4++)
                        {
                            for (var symbol5 = Math.Max(symbol1, symbol2) + 1; symbol5 <= n; symbol5++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", symbol1, symbol2, symbol3, symbol4, symbol5);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
