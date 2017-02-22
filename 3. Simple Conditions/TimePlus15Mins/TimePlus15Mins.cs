using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Mins
{
    class TimePlus15Mins
    {
        static void Main(string[] args)
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
