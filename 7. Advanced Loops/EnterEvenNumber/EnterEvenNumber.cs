using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            //int num = 0;

            //try
            //{
            //    Console.Write("Even enter number: ");
            //    num = int.Parse(Console.ReadLine());
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("The number is not even");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid number."); ;
            //}

            int n;
            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            } while (true);
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
