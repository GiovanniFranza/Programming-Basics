using System;

namespace _14.TimePlus15Minutes
{
    public class TimePlus15Minutes
    {
        public static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var plusMinute = minute + 15;

            if (plusMinute > 59)
            {
                hour++; plusMinute -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            if (plusMinute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, plusMinute);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, plusMinute);
            }
        }
    }
}
