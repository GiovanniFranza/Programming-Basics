using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMarket
{
    class FruitMarket
    {
        static void Main(string[] args)
        {
            var costVegetable = double.Parse(Console.ReadLine());
            var costFruit = double.Parse(Console.ReadLine());
            var weightVegetable = int.Parse(Console.ReadLine());
            var weightFruit = int.Parse(Console.ReadLine());

            var PriseVegetable = costVegetable * weightVegetable;
            var PriseFruit = costFruit * weightFruit;

            var EUR = (PriseVegetable + PriseFruit) / 1.94;

            Console.WriteLine(EUR);
        }
    }
}
