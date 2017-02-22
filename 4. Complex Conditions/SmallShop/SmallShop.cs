using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                if (product == "coffee") Console.WriteLine(0.5 * quantity);
                else if (product == "water") Console.WriteLine(0.8 * quantity);
                else if (product == "beer") Console.WriteLine(1.2 * quantity);
                else if (product == "sweets") Console.WriteLine(1.45 * quantity);
                else if (product == "peanuts") Console.WriteLine(1.60 * quantity);
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee") Console.WriteLine(0.4 * quantity);
                else if (product == "water") Console.WriteLine(0.7 * quantity);
                else if (product == "beer") Console.WriteLine(1.15 * quantity);
                else if (product == "sweets") Console.WriteLine(1.30 * quantity);
                else if (product == "peanuts") Console.WriteLine(1.50 * quantity);
            }
            if (town == "Varna")
            {
                if (product == "coffee") Console.WriteLine(0.45 * quantity);
                else if (product == "water") Console.WriteLine(0.7 * quantity);
                else if (product == "beer") Console.WriteLine(1.1 * quantity);
                else if (product == "sweets") Console.WriteLine(1.35 * quantity);
                else if (product == "peanuts") Console.WriteLine(1.55 * quantity);
            }
        }
    }
}
