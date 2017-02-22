using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            switch (name)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile":
                case "tortoise":
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("Unknown"); break;
            }

        }
    }
}
