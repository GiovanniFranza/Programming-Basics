using System;

namespace _04.GreaterNumber
{
    public class GreaterNumber
    {
        public static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
