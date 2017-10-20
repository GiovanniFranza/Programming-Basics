using System;

namespace _16.MagicNumber
{
    public class MagicNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num1 = 0; num1 <= 9; num1++)
            {
                for (int num2 = 0; num2 <= 9; num2++)
                {
                    for (int num3 = 0; num3 <= 9; num3++)
                    {
                        for (int num4 = 0; num4 <= 9; num4++)
                        {
                            for (int num5 = 0; num5 <= 9; num5++)
                            {
                                for (int num6 = 0; num6 <= 9; num6++)
                                {
                                    if (num1 * num2 * num3 * num4 * num5 * num6 == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", num1, num2, num3, num4, num5, num6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
