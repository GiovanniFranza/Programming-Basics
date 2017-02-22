using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRoom
{
    class StudentRoom
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var placeh = (h - (h % 1.20)) / 1.20;
            var placew = ((w - 1) - ((w - 1) % 0.70)) / 0.70;

            var Place = (placeh * placew) - 3;

            Console.WriteLine(Place);
        }
    }
}
