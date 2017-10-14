using System;

namespace _18.PipeAndPool
{
    public class PipeAndPool
    {
        public static void Main()
        {
            var volume = int.Parse(Console.ReadLine());
            var firstPipe = int.Parse(Console.ReadLine());
            var secondPipe = int.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var pipe1 = firstPipe * height;
            var pipe2 = secondPipe * height;
            var sum = pipe1 + pipe2;


            if (sum <= volume)
            {
                var Vpercent = (sum / volume) * 100;
                var pipe1Percent = (pipe1 / sum) * 100;
                var pipe2Percent = (pipe2 / sum) * 100;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1:F0}%. Pipe 2: {2:F0}%.", Math.Truncate(Vpercent), Math.Truncate(pipe1Percent), Math.Truncate(pipe2Percent));
            }
            else
            {
                var overflow = sum - volume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", height, overflow);
            }
        }
    }
}
