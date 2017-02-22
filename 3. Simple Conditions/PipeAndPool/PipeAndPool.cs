using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeAndPool
{
    class PipeAndPool
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var pipe1 = P1 * h;
            var pipe2 = P2 * h;
            var sum = pipe1 + pipe2;


            if (sum <= V)
            {
                var Vpercent = (sum / V) * 100;
                var pipe1Percent = (pipe1 / sum) * 100;
                var pipe2Percent = (pipe2 / sum) * 100;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1:F0}%. Pipe 2: {2:F0}%.", Math.Truncate(Vpercent), Math.Truncate(pipe1Percent), Math.Truncate(pipe2Percent));
            }
            else
            {
                var overflow = sum - V;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, overflow);
            }
        }
    }
}
