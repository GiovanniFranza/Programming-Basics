using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationBetweenNumber
{
    class OperationBetweenNumber
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            if (operation == "+")
            {
                var sum = N1 + N2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, operation, N2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, operation, N2, sum);
                }
            }
            else if (operation == "-")
            {
                var sum = N1 - N2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, operation, N2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, operation, N2, sum);
                }
            }
            else if (operation == "*")
            {
                var sum = N1 * N2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, operation, N2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, operation, N2, sum);
                }
            }
            else if (operation == "/")
            {
                var sum = N1 / N2;
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3:F2}", N1, operation, N2, sum);
                }
            }
            else if (operation == "%")
            {
                var sum = N1 % N2;
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", N1, operation, N2, sum);
                }
            }
        }
    }
}
