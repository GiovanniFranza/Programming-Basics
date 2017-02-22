using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessPassword
{
    class GuessPassword
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else if (password != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
