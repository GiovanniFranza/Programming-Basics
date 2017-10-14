using System;

namespace _08.MetricConverter
{
    public class MetricConverter
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var inUnit = Console.ReadLine();
            var outUnit = Console.ReadLine();

            var meters = 0d;

            if (inUnit == "mm")
            {
                meters = num / 1000;
            }
            else if (inUnit == "cm")
            {
                meters = num / 100;
            }
            else if (inUnit == "mi")
            {
                meters = num / 0.000621371192;
            }
            else if (inUnit == "in")
            {
                meters = num / 39.3700787;
            }
            else if (inUnit == "km")
            {
                meters = num / 0.001;
            }
            else if (inUnit == "ft")
            {
                meters = num / 3.2808399;
            }
            else if (inUnit == "yd")
            {
                meters = num / 1.0936133;
            }
            else if (inUnit == "m")
            {
                meters = num;
            }

            var outNum = 0d;

            if (outUnit == "mm")
            {
                outNum = meters * 1000;
            }
            else if (outUnit == "cm")
            {
                outNum = meters * 100;
            }
            else if (outUnit == "mi")
            {
                outNum = meters * 0.000621371192;
            }
            else if (outUnit == "in")
            {
                outNum = meters * 39.3700787;
            }
            else if (outUnit == "km")
            {
                outNum = meters * 0.001;
            }
            else if (outUnit == "ft")
            {
                outNum = meters * 3.2808399;
            }
            else if (outUnit == "yd")
            {
                outNum = meters * 1.0936133;
            }
            else if (outUnit == "m")
            {
                outNum = meters;
            }

            Console.WriteLine(outNum + " " + outUnit);
        }
    }
}
