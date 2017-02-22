using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            if (name == "banana" || name == "apple" || name == "kiwi" || name == "cherry" || name == "lemon" || name == "grapes")
            {
                Console.WriteLine("Fruit");
            }
            else if (name == "tomato" || name == "cucumber" || name == "pepper" || name == "carrot")
            {
                Console.WriteLine("Vegetable");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }
}
