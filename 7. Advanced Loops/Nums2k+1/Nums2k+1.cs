using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            while (n >= num)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
