using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double saveMoney = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double highTriangle = double.Parse(Console.ReadLine());
            double priceTile = double.Parse(Console.ReadLine());
            double worker = double.Parse(Console.ReadLine());

            double area = width * lenght;
            double areaTriangle = sideTriangle * (highTriangle / 2);
            double needTiles = Math.Ceiling(area / areaTriangle) + 5;
            double total = needTiles * priceTile + worker;

            if (total <= saveMoney)
            {
                Console.WriteLine("{0:F2} lv left.", saveMoney - total);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.", total - saveMoney);
            }
        }
    }
}
