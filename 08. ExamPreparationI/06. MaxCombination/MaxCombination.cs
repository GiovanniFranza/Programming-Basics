using System;

namespace _06.MaxCombination
{
    public class MaxCombination
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int combination = 0;

            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    if (combination >= max)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, j);
                    combination++;
                }
            }
            Console.WriteLine();
        }
    }
}
