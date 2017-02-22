using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            if (Math.Abs(leftSum - rightSum) == 0)
            {
                Console.WriteLine("Yes sum " + leftSum);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
