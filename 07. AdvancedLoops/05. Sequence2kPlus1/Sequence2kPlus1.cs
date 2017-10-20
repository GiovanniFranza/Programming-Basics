using System;

namespace _05.Sequence2kPlus1
{
    public class Sequence2kPlus1
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (n >= num)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
