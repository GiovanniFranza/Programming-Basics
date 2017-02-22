using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (num <= 100)
            {
                bonusScore =+ 5;
            }
            else if (100 < num && num < 1000)
            {
                bonusScore = num * 0.20;
            }
            else if(num > 1000)
            {
                bonusScore = num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonusScore =+ 1 + bonusScore;
            }
            if (num % 10 == 5)
            {
                bonusScore =+ 2 + bonusScore;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}
