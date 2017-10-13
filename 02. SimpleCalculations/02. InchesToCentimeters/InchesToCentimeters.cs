using System;

namespace _02.InchesToCentimeters
{
    public class InchesToCentimeters
    {
        public static void Main()
        {
            var inchs = double.Parse(Console.ReadLine());
            var centimeters = inchs * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}
