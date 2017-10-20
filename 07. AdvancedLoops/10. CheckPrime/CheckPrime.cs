using System;

namespace _10.CheckPrime
{
    public class CheckPrime
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                bool prime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
