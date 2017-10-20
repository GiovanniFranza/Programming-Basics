using System;

namespace _01.Numbers1ToNWithStep3
{
    public class Numbers1ToNWithStep3
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
